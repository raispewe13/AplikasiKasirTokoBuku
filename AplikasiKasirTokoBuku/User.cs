using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplikasiKasirTokoBuku
{
    public class User
    {
        // 1. Atribut Enkapsulasi Properti OOP untuk entitas data Pengguna (User)
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // 2. Fungsi memeriksa kecocokan username dan password di database saat login
        public bool ValidasiLogin(string user, string pass, string roleTerpilih)
        {
            bool status = false; // Status awal diset default gagal (false)

            // Membuka koneksi menggunakan blok 'using' agar koneksi otomatis tertutup aman saat selesai
            using (MySqlConnection conn = Koneksi.GetKoneksi())
            {
                // PERBAIKAN: Menambahkan kondisi AND role = @role agar hak akses ikut diperiksa oleh MySQL
                string query = "SELECT id_user, username, role FROM users WHERE username = @user AND password = @pass AND role = @role";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Mengikat tiga parameter query dengan data inputan dari Form Login
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@role", roleTerpilih); // Mengikat parameter role baru

                    try
                    {
                        conn.Open(); // Membuka jalur pintu akses ke database MySQL

                        // Menjalankan perintah dan menampung hasilnya baris per baris
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Jika Username, Password, DAN Role ketiganya COCOK
                            {
                                // Menyimpan identitas pengguna aktif ke sesi global program
                                Program.IDUserAktif = Convert.ToInt32(reader["id_user"]);
                                Program.UsernameAktif = reader["username"].ToString();
                                this.Role = reader["role"].ToString(); // Menyimpan role objek saat ini
                                status = true; // Validasi dinyatakan sukses total (true)
                            }
                        }
                    }
                    catch (Exception) { throw; } // Melempar exception jika terjadi kegagalan database
                }
            }
            return status; // Mengembalikan hasil akhir validasi tiga kombinasi
        }

        // 3. Fungsi memvalidasi ketersediaan nama username agar tidak kembar saat mendaftar baru
        public bool CekUsernameTerdaftar(string user)
        {
            using (MySqlConnection conn = Koneksi.GetKoneksi())
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @user";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    conn.Open();
                    // Mengambil satu nilai skalar angka bulat dari baris hitungan SQL COUNT
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Mengembalikan true jika angka baris lebih besar dari nol (artinya sudah dipakai)
                }
            }
        }

        // 4. Fungsi menyimpan/insert record akun user baru hasil pendaftaran lokal siswa ke database
        public bool RegistrasiUserBaru()
        {
            using (MySqlConnection conn = Koneksi.GetKoneksi())
            {
                string query = "INSERT INTO users (username, password, role) VALUES (@user, @pass, @role)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", this.Username);
                    cmd.Parameters.AddWithValue("@pass", this.Password);
                    cmd.Parameters.AddWithValue("@role", this.Role);
                    conn.Open();
                    // Mengeksekusi instruksi INSERT, mengembalikan nilai sukses true jika ada baris data masuk
                    return cmd.ExecuteNonQuery() > 0;
                }
            }


        }
    }
}

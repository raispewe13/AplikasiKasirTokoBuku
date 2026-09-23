using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplikasiKasirTokoBuku
{
    public class Koneksi
    {
        // 1. Menyimpan alamat parameter koneksi database MySQL lokal tanpa password sesuai instruksi
        private static string connectionString = "Server=localhost;Username=root;Port=3306;database=db_tokobuku";

        // 2. Fungsi statis (OOP Method) untuk memanggil dan membuka objek koneksi dari kelas manapun
        public static MySqlConnection GetKoneksi()
        {
            // Mengembalikan objek instansiasi koneksi baru yang siap dipanggil
            return new MySqlConnection(connectionString);
        }
    }
}

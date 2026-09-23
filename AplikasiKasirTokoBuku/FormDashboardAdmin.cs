using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasirTokoBuku
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }
        // Kejadian saat Form Utama Admin pertama kali dibuka ke layar monitor
        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Mengubah kalimat sambutan teks label dengan mengambil variabel sesi nama user aktif global
            lblSelamatDatang.Text = "Selamat Datang, " + Program.UsernameAktif + "!";
        }

        private void btnMenuBuku_Click(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan dashboard admin
            FormManajemenBuku frm = new FormManajemenBuku();
            frm.Show();  // Buka form kelola buku
        }

        private void btnMenuStok_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManajemenStok frm = new FormManajemenStok();
            frm.Show();
        }

        private void btnMenuLaporan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaporanPenjualan frm = new FormLaporanPenjualan();
            frm.Show();
        }

        private void btnMenuBackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBackupRestore frm = new FormBackupRestore();
            frm.Show();
        }

        // Aksi tombol logout keluar aman sistem aplikasi kasir toko buku
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Membersihkan sisa rekor memori jejak riwayat variabel sesi login global
            Program.IDUserAktif = 0;
            Program.UsernameAktif = "";

            MessageBox.Show("Sesi dikeluarkan secara aman.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // Menyembunyikan jendela dasbor admin

            FormLogin login = new FormLogin();
            login.Show(); // Menampilkan ulang gerbang pintu form login orisinil mula-mula
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

    }
}

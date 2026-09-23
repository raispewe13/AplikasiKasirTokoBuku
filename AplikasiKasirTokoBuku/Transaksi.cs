using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AplikasiKasirTokoBuku
{
    public class Transaksi
    {
        // 1. Method mencari data buku secara dinamis via barcode kode buku ataupun potongan teks judul
        public static DataTable CariBuku(string keyword)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.GetKoneksi())
            {
                string query = "SELECT id_buku, kode_buku, judul, harga, stok FROM books WHERE kode_buku = @key OR judul LIKE @keyLike";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@key", keyword);
                    // Menggunakan tanda persen % agar SQL mencari kata yang memiliki kemiripan teks
                    cmd.Parameters.AddWithValue("@keyLike", "%" + keyword + "%");
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // 2. Method menarik rangkuman data pembukuan laba penjualan dengan teknik INNER JOIN multi tabel
        public static DataTable AmbilLaporan(DateTime dari, DateTime sampai)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.GetKoneksi())
            {
                // Menghubungkan tabel detail transaksi, tabel transaksi induk keuangan, dan tabel data buku
                string query = @"SELECT t.tanggal AS `Tanggal Transaksi`, b.judul AS `Judul Buku`, 
                                 td.jumlah AS `Jumlah Terjual`, td.subtotal AS `Total Pendapatan` 
                                 FROM transaction_details td
                                 INNER JOIN transactions t ON td.id_transaksi = t.id_transaksi
                                 INNER JOIN books b ON td.id_buku = b.id_buku
                                 WHERE t.tanggal BETWEEN @mulai AND @selesai";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mulai", dari);
                    cmd.Parameters.AddWithValue("@selesai", sampai);
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt; // Mengembalikan data hasil filter pencarian rentang tanggal
        }
    }
}

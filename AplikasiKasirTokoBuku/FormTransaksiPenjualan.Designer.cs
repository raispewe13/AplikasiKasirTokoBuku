namespace AplikasiKasirTokoBuku
{
    partial class FormTransaksiPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.txtCariBuku = new System.Windows.Forms.TextBox();
            this.txtJumlahBeli = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnTambahKeranjang = new System.Windows.Forms.Button();
            this.btnHapusItem = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnKembaliDashboard = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(66, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI PENJUALAN BUKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari Buku (kode/Judul)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buku Dipilih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Beli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TOTAL PEMBAYARAN: Rp.";
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(8, 185);
            this.dgvKeranjang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.RowHeadersWidth = 62;
            this.dgvKeranjang.RowTemplate.Height = 28;
            this.dgvKeranjang.Size = new System.Drawing.Size(1117, 202);
            this.dgvKeranjang.TabIndex = 7;
            // 
            // txtCariBuku
            // 
            this.txtCariBuku.Location = new System.Drawing.Point(125, 109);
            this.txtCariBuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCariBuku.Name = "txtCariBuku";
            this.txtCariBuku.Size = new System.Drawing.Size(187, 20);
            this.txtCariBuku.TabIndex = 8;
            // 
            // txtJumlahBeli
            // 
            this.txtJumlahBeli.Location = new System.Drawing.Point(72, 157);
            this.txtJumlahBeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJumlahBeli.Name = "txtJumlahBeli";
            this.txtJumlahBeli.Size = new System.Drawing.Size(66, 20);
            this.txtJumlahBeli.TabIndex = 9;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(74, 140);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(35, 13);
            this.lblJudul.TabIndex = 10;
            this.lblJudul.Text = "label8";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(191, 140);
            this.lblHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(35, 13);
            this.lblHarga.TabIndex = 11;
            this.lblHarga.Text = "label9";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(305, 140);
            this.lblStok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(41, 13);
            this.lblStok.TabIndex = 12;
            this.lblStok.Text = "label10";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(152, 396);
            this.lblTotalHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(41, 13);
            this.lblTotalHarga.TabIndex = 13;
            this.lblTotalHarga.Text = "label11";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(315, 109);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(65, 18);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnTambahKeranjang
            // 
            this.btnTambahKeranjang.Location = new System.Drawing.Point(141, 157);
            this.btnTambahKeranjang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTambahKeranjang.Name = "btnTambahKeranjang";
            this.btnTambahKeranjang.Size = new System.Drawing.Size(76, 18);
            this.btnTambahKeranjang.TabIndex = 15;
            this.btnTambahKeranjang.Text = "Tambah";
            this.btnTambahKeranjang.UseVisualStyleBackColor = true;
            this.btnTambahKeranjang.Click += new System.EventHandler(this.btnTambahKeranjang_Click);
            // 
            // btnHapusItem
            // 
            this.btnHapusItem.Location = new System.Drawing.Point(1042, 391);
            this.btnHapusItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(83, 18);
            this.btnHapusItem.TabIndex = 16;
            this.btnHapusItem.Text = "Hapus Item";
            this.btnHapusItem.UseVisualStyleBackColor = true;
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(8, 411);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(111, 18);
            this.btnBayar.TabIndex = 17;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnKembaliDashboard
            // 
            this.btnKembaliDashboard.Location = new System.Drawing.Point(11, 67);
            this.btnKembaliDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKembaliDashboard.Name = "btnKembaliDashboard";
            this.btnKembaliDashboard.Size = new System.Drawing.Size(69, 23);
            this.btnKembaliDashboard.TabIndex = 19;
            this.btnKembaliDashboard.Text = "Dashboard";
            this.btnKembaliDashboard.UseVisualStyleBackColor = true;
            this.btnKembaliDashboard.Click += new System.EventHandler(this.btnKembaliDashboard_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(695, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // FormTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplikasiKasirTokoBuku.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 436);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKembaliDashboard);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnHapusItem);
            this.Controls.Add(this.btnTambahKeranjang);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtJumlahBeli);
            this.Controls.Add(this.txtCariBuku);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTransaksiPenjualan";
            this.Text = "FormTransaksiPenjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTransaksiPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.TextBox txtCariBuku;
        private System.Windows.Forms.TextBox txtJumlahBeli;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambahKeranjang;
        private System.Windows.Forms.Button btnHapusItem;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnKembaliDashboard;
        private System.Windows.Forms.Label label8;
    }
}
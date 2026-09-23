namespace AplikasiKasirTokoBuku
{
    partial class FormDashboardAdmin
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
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.btnMenuBuku = new System.Windows.Forms.Button();
            this.btnMenuStok = new System.Windows.Forms.Button();
            this.btnMenuLaporan = new System.Windows.Forms.Button();
            this.btnMenuBackup = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard ADMIN";
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelamatDatang.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblSelamatDatang.Location = new System.Drawing.Point(239, 63);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(345, 41);
            this.lblSelamatDatang.TabIndex = 1;
            this.lblSelamatDatang.Text = "lblSelamatDatang";
            // 
            // btnMenuBuku
            // 
            this.btnMenuBuku.Location = new System.Drawing.Point(33, 127);
            this.btnMenuBuku.Name = "btnMenuBuku";
            this.btnMenuBuku.Size = new System.Drawing.Size(267, 68);
            this.btnMenuBuku.TabIndex = 2;
            this.btnMenuBuku.Text = "Management Buku";
            this.btnMenuBuku.UseVisualStyleBackColor = true;
            this.btnMenuBuku.Click += new System.EventHandler(this.btnMenuBuku_Click);
            // 
            // btnMenuStok
            // 
            this.btnMenuStok.Location = new System.Drawing.Point(33, 201);
            this.btnMenuStok.Name = "btnMenuStok";
            this.btnMenuStok.Size = new System.Drawing.Size(267, 73);
            this.btnMenuStok.TabIndex = 3;
            this.btnMenuStok.Text = "Management stok";
            this.btnMenuStok.UseVisualStyleBackColor = true;
            this.btnMenuStok.Click += new System.EventHandler(this.btnMenuStok_Click);
            // 
            // btnMenuLaporan
            // 
            this.btnMenuLaporan.Location = new System.Drawing.Point(33, 280);
            this.btnMenuLaporan.Name = "btnMenuLaporan";
            this.btnMenuLaporan.Size = new System.Drawing.Size(267, 67);
            this.btnMenuLaporan.TabIndex = 4;
            this.btnMenuLaporan.Text = "Laporan Penjualan";
            this.btnMenuLaporan.UseVisualStyleBackColor = true;
            this.btnMenuLaporan.Click += new System.EventHandler(this.btnMenuLaporan_Click);
            // 
            // btnMenuBackup
            // 
            this.btnMenuBackup.Location = new System.Drawing.Point(33, 353);
            this.btnMenuBackup.Name = "btnMenuBackup";
            this.btnMenuBackup.Size = new System.Drawing.Size(267, 69);
            this.btnMenuBackup.TabIndex = 5;
            this.btnMenuBackup.Text = "Backup";
            this.btnMenuBackup.UseVisualStyleBackColor = true;
            this.btnMenuBackup.Click += new System.EventHandler(this.btnMenuBackup_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(694, 403);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuBackup);
            this.Controls.Add(this.btnMenuLaporan);
            this.Controls.Add(this.btnMenuStok);
            this.Controls.Add(this.btnMenuBuku);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboardAdmin";
            this.Text = "FormDashboardAdmin";
            this.Load += new System.EventHandler(this.FormDashboardAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Button btnMenuBuku;
        private System.Windows.Forms.Button btnMenuStok;
        private System.Windows.Forms.Button btnMenuLaporan;
        private System.Windows.Forms.Button btnMenuBackup;
        private System.Windows.Forms.Button btnLogout;
    }
}
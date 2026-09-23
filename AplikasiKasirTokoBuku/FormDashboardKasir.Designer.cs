namespace AplikasiKasirTokoBuku
{
    partial class FormDashboardKasir
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
            this.btnMenuTransaksi = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DashBoard KASIR";
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Location = new System.Drawing.Point(312, 113);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(143, 20);
            this.lblSelamatDatang.TabIndex = 1;
            this.lblSelamatDatang.Text = "DashBoard KASIR";
            // 
            // btnMenuTransaksi
            // 
            this.btnMenuTransaksi.Location = new System.Drawing.Point(12, 221);
            this.btnMenuTransaksi.Name = "btnMenuTransaksi";
            this.btnMenuTransaksi.Size = new System.Drawing.Size(203, 35);
            this.btnMenuTransaksi.TabIndex = 2;
            this.btnMenuTransaksi.Text = "Transaksi";
            this.btnMenuTransaksi.UseVisualStyleBackColor = true;
            this.btnMenuTransaksi.Click += new System.EventHandler(this.btnMenuTransaksi_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 262);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(203, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormDashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuTransaksi);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboardKasir";
            this.Text = "FormDashboardKasir";
            this.Load += new System.EventHandler(this.FormDashboardKasir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Button btnMenuTransaksi;
        private System.Windows.Forms.Button btnLogout;
    }
}
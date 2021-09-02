namespace BilgiYonetimiProje
{
    partial class frmKitapSevkiyati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapSevkiyati));
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lbşBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSevkiyat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYayinEvi = new System.Windows.Forms.Label();
            this.cmboxKitapci = new System.Windows.Forms.ComboBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblKargoFirmasi = new System.Windows.Forms.Label();
            this.cmboxKitapAdi = new System.Windows.Forms.ComboBox();
            this.cmboxKargoFirmasi = new System.Windows.Forms.ComboBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAdedi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKargoNumarasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.cmboxYayınEvi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSevkiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBaslik
            // 
            this.pnlBaslik.BackColor = System.Drawing.Color.Transparent;
            this.pnlBaslik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBaslik.BackgroundImage")));
            this.pnlBaslik.Controls.Add(this.lbşBaslik);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.Location = new System.Drawing.Point(0, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Size = new System.Drawing.Size(642, 106);
            this.pnlBaslik.TabIndex = 5;
            // 
            // lbşBaslik
            // 
            this.lbşBaslik.AutoSize = true;
            this.lbşBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbşBaslik.ForeColor = System.Drawing.Color.White;
            this.lbşBaslik.Location = new System.Drawing.Point(117, 32);
            this.lbşBaslik.Name = "lbşBaslik";
            this.lbşBaslik.Size = new System.Drawing.Size(387, 39);
            this.lbşBaslik.TabIndex = 0;
            this.lbşBaslik.Text = "KİTAP SEVKİYATLARI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(259, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEVKİYATLAR";
            // 
            // dataGridSevkiyat
            // 
            this.dataGridSevkiyat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSevkiyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSevkiyat.Location = new System.Drawing.Point(26, 169);
            this.dataGridSevkiyat.Name = "dataGridSevkiyat";
            this.dataGridSevkiyat.Size = new System.Drawing.Size(604, 150);
            this.dataGridSevkiyat.TabIndex = 7;
            this.dataGridSevkiyat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "YENİ SEVİKİYAT";
            // 
            // lblYayinEvi
            // 
            this.lblYayinEvi.AutoSize = true;
            this.lblYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinEvi.Location = new System.Drawing.Point(83, 429);
            this.lblYayinEvi.Name = "lblYayinEvi";
            this.lblYayinEvi.Size = new System.Drawing.Size(48, 16);
            this.lblYayinEvi.TabIndex = 13;
            this.lblYayinEvi.Text = "Kitapçı";
            // 
            // cmboxKitapci
            // 
            this.cmboxKitapci.FormattingEnabled = true;
            this.cmboxKitapci.Location = new System.Drawing.Point(139, 424);
            this.cmboxKitapci.Name = "cmboxKitapci";
            this.cmboxKitapci.Size = new System.Drawing.Size(121, 21);
            this.cmboxKitapci.TabIndex = 14;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(90, 468);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(41, 16);
            this.lblKitapAdi.TabIndex = 15;
            this.lblKitapAdi.Text = "Kitap:";
            // 
            // lblKargoFirmasi
            // 
            this.lblKargoFirmasi.AutoSize = true;
            this.lblKargoFirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKargoFirmasi.Location = new System.Drawing.Point(37, 507);
            this.lblKargoFirmasi.Name = "lblKargoFirmasi";
            this.lblKargoFirmasi.Size = new System.Drawing.Size(94, 16);
            this.lblKargoFirmasi.TabIndex = 17;
            this.lblKargoFirmasi.Text = "Kargo Firması:";
            // 
            // cmboxKitapAdi
            // 
            this.cmboxKitapAdi.FormattingEnabled = true;
            this.cmboxKitapAdi.Location = new System.Drawing.Point(139, 463);
            this.cmboxKitapAdi.Name = "cmboxKitapAdi";
            this.cmboxKitapAdi.Size = new System.Drawing.Size(121, 21);
            this.cmboxKitapAdi.TabIndex = 18;
            // 
            // cmboxKargoFirmasi
            // 
            this.cmboxKargoFirmasi.FormattingEnabled = true;
            this.cmboxKargoFirmasi.Location = new System.Drawing.Point(139, 502);
            this.cmboxKargoFirmasi.Name = "cmboxKargoFirmasi";
            this.cmboxKargoFirmasi.Size = new System.Drawing.Size(121, 21);
            this.cmboxKargoFirmasi.TabIndex = 19;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(139, 582);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(99, 28);
            this.btnGonder.TabIndex = 20;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kitap Adedi:";
            // 
            // txtKitapAdedi
            // 
            this.txtKitapAdedi.Location = new System.Drawing.Point(139, 541);
            this.txtKitapAdedi.Name = "txtKitapAdedi";
            this.txtKitapAdedi.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAdedi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(405, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "SEVKİYAT İPTALİ";
            // 
            // txtKargoNumarasi
            // 
            this.txtKargoNumarasi.Location = new System.Drawing.Point(462, 420);
            this.txtKargoNumarasi.Name = "txtKargoNumarasi";
            this.txtKargoNumarasi.Size = new System.Drawing.Size(121, 20);
            this.txtKargoNumarasi.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(348, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kargo Numarası:";
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(436, 500);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(99, 28);
            this.btnİptal.TabIndex = 26;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // cmboxYayınEvi
            // 
            this.cmboxYayınEvi.FormattingEnabled = true;
            this.cmboxYayınEvi.Location = new System.Drawing.Point(139, 385);
            this.cmboxYayınEvi.Name = "cmboxYayınEvi";
            this.cmboxYayınEvi.Size = new System.Drawing.Size(121, 21);
            this.cmboxYayınEvi.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gönderen YayınEvi:";
            // 
            // frmKitapSevkiyati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 622);
            this.Controls.Add(this.cmboxYayınEvi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.txtKargoNumarasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKitapAdedi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.cmboxKargoFirmasi);
            this.Controls.Add(this.cmboxKitapAdi);
            this.Controls.Add(this.lblKargoFirmasi);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.cmboxKitapci);
            this.Controls.Add(this.lblYayinEvi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridSevkiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKitapSevkiyati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKitapSevkiyati";
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSevkiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label lbşBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridSevkiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYayinEvi;
        private System.Windows.Forms.ComboBox cmboxKitapci;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblKargoFirmasi;
        private System.Windows.Forms.ComboBox cmboxKitapAdi;
        private System.Windows.Forms.ComboBox cmboxKargoFirmasi;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAdedi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKargoNumarasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ComboBox cmboxYayınEvi;
        private System.Windows.Forms.Label label6;
    }
}
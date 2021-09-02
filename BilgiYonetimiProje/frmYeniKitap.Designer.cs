namespace BilgiYonetimiProje
{
    partial class frmYeniKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKitap));
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lbşBaslik = new System.Windows.Forms.Label();
            this.pnlKitapKaydi = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtCevirmen = new System.Windows.Forms.TextBox();
            this.comboBoxKitapTuru = new System.Windows.Forms.ComboBox();
            this.dateTimeYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.comboboxYazar = new System.Windows.Forms.ComboBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtISBNO = new System.Windows.Forms.TextBox();
            this.lblCevirmen = new System.Windows.Forms.Label();
            this.lblKitapTuru = new System.Windows.Forms.Label();
            this.lblYayinTarihi = new System.Windows.Forms.Label();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.lblİSBN_No = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.pnlBaslik.SuspendLayout();
            this.pnlKitapKaydi.SuspendLayout();
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
            this.pnlBaslik.Size = new System.Drawing.Size(658, 106);
            this.pnlBaslik.TabIndex = 3;
            // 
            // lbşBaslik
            // 
            this.lbşBaslik.AutoSize = true;
            this.lbşBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbşBaslik.ForeColor = System.Drawing.Color.White;
            this.lbşBaslik.Location = new System.Drawing.Point(190, 34);
            this.lbşBaslik.Name = "lbşBaslik";
            this.lbşBaslik.Size = new System.Drawing.Size(239, 39);
            this.lbşBaslik.TabIndex = 0;
            this.lbşBaslik.Text = "KİTAP KAYDI";
            // 
            // pnlKitapKaydi
            // 
            this.pnlKitapKaydi.Controls.Add(this.btnPDF);
            this.pnlKitapKaydi.Controls.Add(this.label1);
            this.pnlKitapKaydi.Controls.Add(this.btnKaydet);
            this.pnlKitapKaydi.Controls.Add(this.txtCevirmen);
            this.pnlKitapKaydi.Controls.Add(this.comboBoxKitapTuru);
            this.pnlKitapKaydi.Controls.Add(this.dateTimeYayinTarihi);
            this.pnlKitapKaydi.Controls.Add(this.txtSayfaSayisi);
            this.pnlKitapKaydi.Controls.Add(this.comboboxYazar);
            this.pnlKitapKaydi.Controls.Add(this.txtKitapAdi);
            this.pnlKitapKaydi.Controls.Add(this.txtISBNO);
            this.pnlKitapKaydi.Controls.Add(this.lblCevirmen);
            this.pnlKitapKaydi.Controls.Add(this.lblKitapTuru);
            this.pnlKitapKaydi.Controls.Add(this.lblYayinTarihi);
            this.pnlKitapKaydi.Controls.Add(this.lblSayfaSayisi);
            this.pnlKitapKaydi.Controls.Add(this.lblİSBN_No);
            this.pnlKitapKaydi.Controls.Add(this.lblYazar);
            this.pnlKitapKaydi.Controls.Add(this.lblKitapAdi);
            this.pnlKitapKaydi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKitapKaydi.Location = new System.Drawing.Point(0, 106);
            this.pnlKitapKaydi.Name = "pnlKitapKaydi";
            this.pnlKitapKaydi.Size = new System.Drawing.Size(658, 559);
            this.pnlKitapKaydi.TabIndex = 4;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(358, 443);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 18;
            this.btnPDF.Text = "SEÇ";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(262, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "PDF:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(491, 478);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 47);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtCevirmen
            // 
            this.txtCevirmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevirmen.Location = new System.Drawing.Point(325, 385);
            this.txtCevirmen.Multiline = true;
            this.txtCevirmen.Name = "txtCevirmen";
            this.txtCevirmen.Size = new System.Drawing.Size(141, 33);
            this.txtCevirmen.TabIndex = 15;
            // 
            // comboBoxKitapTuru
            // 
            this.comboBoxKitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKitapTuru.FormattingEnabled = true;
            this.comboBoxKitapTuru.Location = new System.Drawing.Point(325, 342);
            this.comboBoxKitapTuru.Name = "comboBoxKitapTuru";
            this.comboBoxKitapTuru.Size = new System.Drawing.Size(141, 24);
            this.comboBoxKitapTuru.TabIndex = 14;
            // 
            // dateTimeYayinTarihi
            // 
            this.dateTimeYayinTarihi.CustomFormat = "yyyy-MM-dd";
            this.dateTimeYayinTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeYayinTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeYayinTarihi.Location = new System.Drawing.Point(321, 290);
            this.dateTimeYayinTarihi.Name = "dateTimeYayinTarihi";
            this.dateTimeYayinTarihi.Size = new System.Drawing.Size(145, 22);
            this.dateTimeYayinTarihi.TabIndex = 13;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(325, 223);
            this.txtSayfaSayisi.Multiline = true;
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(141, 33);
            this.txtSayfaSayisi.TabIndex = 11;
            // 
            // comboboxYazar
            // 
            this.comboboxYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboboxYazar.FormattingEnabled = true;
            this.comboboxYazar.Location = new System.Drawing.Point(325, 175);
            this.comboboxYazar.Name = "comboboxYazar";
            this.comboboxYazar.Size = new System.Drawing.Size(141, 24);
            this.comboboxYazar.TabIndex = 10;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(325, 99);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(141, 33);
            this.txtKitapAdi.TabIndex = 9;
            // 
            // txtISBNO
            // 
            this.txtISBNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtISBNO.Location = new System.Drawing.Point(325, 44);
            this.txtISBNO.Multiline = true;
            this.txtISBNO.Name = "txtISBNO";
            this.txtISBNO.Size = new System.Drawing.Size(141, 33);
            this.txtISBNO.TabIndex = 8;
            // 
            // lblCevirmen
            // 
            this.lblCevirmen.AutoSize = true;
            this.lblCevirmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevirmen.ForeColor = System.Drawing.Color.Black;
            this.lblCevirmen.Location = new System.Drawing.Point(119, 394);
            this.lblCevirmen.Name = "lblCevirmen";
            this.lblCevirmen.Size = new System.Drawing.Size(195, 24);
            this.lblCevirmen.TabIndex = 7;
            this.lblCevirmen.Text = "ÇEVİRMEN (VARSA):";
            // 
            // lblKitapTuru
            // 
            this.lblKitapTuru.AutoSize = true;
            this.lblKitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapTuru.ForeColor = System.Drawing.Color.Black;
            this.lblKitapTuru.Location = new System.Drawing.Point(190, 342);
            this.lblKitapTuru.Name = "lblKitapTuru";
            this.lblKitapTuru.Size = new System.Drawing.Size(124, 24);
            this.lblKitapTuru.TabIndex = 6;
            this.lblKitapTuru.Text = "KİTAP TÜRÜ:";
            // 
            // lblYayinTarihi
            // 
            this.lblYayinTarihi.AutoSize = true;
            this.lblYayinTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblYayinTarihi.Location = new System.Drawing.Point(180, 286);
            this.lblYayinTarihi.Name = "lblYayinTarihi";
            this.lblYayinTarihi.Size = new System.Drawing.Size(135, 24);
            this.lblYayinTarihi.TabIndex = 5;
            this.lblYayinTarihi.Text = "YAYIN TARİHİ:";
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfaSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(180, 232);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(139, 24);
            this.lblSayfaSayisi.TabIndex = 4;
            this.lblSayfaSayisi.Text = "SAYFA SAYISI:";
            // 
            // lblİSBN_No
            // 
            this.lblİSBN_No.AutoSize = true;
            this.lblİSBN_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİSBN_No.ForeColor = System.Drawing.Color.Black;
            this.lblİSBN_No.Location = new System.Drawing.Point(154, 48);
            this.lblİSBN_No.Name = "lblİSBN_No";
            this.lblİSBN_No.Size = new System.Drawing.Size(160, 24);
            this.lblİSBN_No.TabIndex = 3;
            this.lblİSBN_No.Text = "ISBN NUMARASI:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.ForeColor = System.Drawing.Color.Black;
            this.lblYazar.Location = new System.Drawing.Point(174, 173);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(140, 24);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "KİTAP YAZARI:";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKitapAdi.Location = new System.Drawing.Point(211, 112);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(103, 24);
            this.lblKitapAdi.TabIndex = 1;
            this.lblKitapAdi.Text = "KİTAP ADI:";
            // 
            // frmYeniKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 661);
            this.Controls.Add(this.pnlKitapKaydi);
            this.Controls.Add(this.pnlBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYeniKitap";
            this.Text = "frmYeniKitap";
            this.Load += new System.EventHandler(this.frmYeniKitap_Load);
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            this.pnlKitapKaydi.ResumeLayout(false);
            this.pnlKitapKaydi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label lbşBaslik;
        private System.Windows.Forms.Panel pnlKitapKaydi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtISBNO;
        private System.Windows.Forms.Label lblCevirmen;
        private System.Windows.Forms.Label lblKitapTuru;
        private System.Windows.Forms.Label lblYayinTarihi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.Label lblİSBN_No;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtCevirmen;
        private System.Windows.Forms.ComboBox comboBoxKitapTuru;
        private System.Windows.Forms.DateTimePicker dateTimeYayinTarihi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox comboboxYazar;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
    }
}
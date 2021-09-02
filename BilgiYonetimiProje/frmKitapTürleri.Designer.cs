namespace BilgiYonetimiProje
{
    partial class frmKitapTürleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapTürleri));
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lbşBaslik = new System.Windows.Forms.Label();
            this.pnlKitapKaydi = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridKitapTuru = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlBaslik.SuspendLayout();
            this.pnlKitapKaydi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKitapTuru)).BeginInit();
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
            this.pnlBaslik.Size = new System.Drawing.Size(625, 106);
            this.pnlBaslik.TabIndex = 4;
            // 
            // lbşBaslik
            // 
            this.lbşBaslik.AutoSize = true;
            this.lbşBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbşBaslik.ForeColor = System.Drawing.Color.White;
            this.lbşBaslik.Location = new System.Drawing.Point(167, 32);
            this.lbşBaslik.Name = "lbşBaslik";
            this.lbşBaslik.Size = new System.Drawing.Size(285, 39);
            this.lbşBaslik.TabIndex = 0;
            this.lbşBaslik.Text = "KİTAP TÜRLERİ";
            // 
            // pnlKitapKaydi
            // 
            this.pnlKitapKaydi.Controls.Add(this.label2);
            this.pnlKitapKaydi.Controls.Add(this.txtKitapTuru);
            this.pnlKitapKaydi.Controls.Add(this.label1);
            this.pnlKitapKaydi.Controls.Add(this.dtGridKitapTuru);
            this.pnlKitapKaydi.Controls.Add(this.btnKaydet);
            this.pnlKitapKaydi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKitapKaydi.Location = new System.Drawing.Point(0, 106);
            this.pnlKitapKaydi.Name = "pnlKitapKaydi";
            this.pnlKitapKaydi.Size = new System.Drawing.Size(625, 559);
            this.pnlKitapKaydi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kitap Türü:";
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapTuru.Location = new System.Drawing.Point(232, 370);
            this.txtKitapTuru.Multiline = true;
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(141, 37);
            this.txtKitapTuru.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mevcut Kitap Türleri:";
            // 
            // dtGridKitapTuru
            // 
            this.dtGridKitapTuru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridKitapTuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridKitapTuru.Location = new System.Drawing.Point(232, 61);
            this.dtGridKitapTuru.Name = "dtGridKitapTuru";
            this.dtGridKitapTuru.Size = new System.Drawing.Size(381, 262);
            this.dtGridKitapTuru.TabIndex = 17;
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(436, 370);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 47);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmKitapTürleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 646);
            this.Controls.Add(this.pnlKitapKaydi);
            this.Controls.Add(this.pnlBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKitapTürleri";
            this.Text = "frmKitapTürleri";
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            this.pnlKitapKaydi.ResumeLayout(false);
            this.pnlKitapKaydi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKitapTuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label lbşBaslik;
        private System.Windows.Forms.Panel pnlKitapKaydi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridKitapTuru;
        private System.Windows.Forms.Label label2;
    }
}
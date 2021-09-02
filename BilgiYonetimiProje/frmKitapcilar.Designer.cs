namespace BilgiYonetimiProje
{
    partial class frmKitapcilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapcilar));
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lbşBaslik = new System.Windows.Forms.Label();
            this.dataGridKitapcilar = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtİl = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKitapciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitapcilar)).BeginInit();
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
            this.pnlBaslik.Size = new System.Drawing.Size(626, 106);
            this.pnlBaslik.TabIndex = 6;
            // 
            // lbşBaslik
            // 
            this.lbşBaslik.AutoSize = true;
            this.lbşBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbşBaslik.ForeColor = System.Drawing.Color.White;
            this.lbşBaslik.Location = new System.Drawing.Point(204, 31);
            this.lbşBaslik.Name = "lbşBaslik";
            this.lbşBaslik.Size = new System.Drawing.Size(227, 39);
            this.lbşBaslik.TabIndex = 0;
            this.lbşBaslik.Text = "KİTAPÇILAR";
            // 
            // dataGridKitapcilar
            // 
            this.dataGridKitapcilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKitapcilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitapcilar.Location = new System.Drawing.Point(20, 137);
            this.dataGridKitapcilar.Name = "dataGridKitapcilar";
            this.dataGridKitapcilar.Size = new System.Drawing.Size(594, 221);
            this.dataGridKitapcilar.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(425, 503);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 32);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(254, 517);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(136, 20);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtİl
            // 
            this.txtİl.Location = new System.Drawing.Point(254, 490);
            this.txtİl.Name = "txtİl";
            this.txtİl.Size = new System.Drawing.Size(136, 20);
            this.txtİl.TabIndex = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(254, 424);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(136, 59);
            this.txtAdres.TabIndex = 11;
            // 
            // txtKitapciAd
            // 
            this.txtKitapciAd.Location = new System.Drawing.Point(254, 397);
            this.txtKitapciAd.Name = "txtKitapciAd";
            this.txtKitapciAd.Size = new System.Drawing.Size(136, 20);
            this.txtKitapciAd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "KİTAPÇI ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ADRES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "İL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "TELEFON:";
            // 
            // frmKitapcilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKitapciAd);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtİl);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridKitapcilar);
            this.Controls.Add(this.pnlBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKitapcilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKitapcilar";
            this.Load += new System.EventHandler(this.frmKitapcilar_Load);
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitapcilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label lbşBaslik;
        private System.Windows.Forms.DataGridView dataGridKitapcilar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtİl;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKitapciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
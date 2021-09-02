namespace BilgiYonetimiProje
{
    partial class frmMevcutYazarBilgisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMevcutYazarBilgisi));
            this.panelYazarlar = new System.Windows.Forms.Panel();
            this.lblBaslikYazar = new System.Windows.Forms.Label();
            this.panelDataGridYazarlar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelYazarlar.SuspendLayout();
            this.panelDataGridYazarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelYazarlar
            // 
            this.panelYazarlar.BackColor = System.Drawing.Color.Transparent;
            this.panelYazarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelYazarlar.BackgroundImage")));
            this.panelYazarlar.Controls.Add(this.lblBaslikYazar);
            this.panelYazarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYazarlar.Location = new System.Drawing.Point(0, 0);
            this.panelYazarlar.Name = "panelYazarlar";
            this.panelYazarlar.Size = new System.Drawing.Size(658, 130);
            this.panelYazarlar.TabIndex = 3;
            // 
            // lblBaslikYazar
            // 
            this.lblBaslikYazar.AutoSize = true;
            this.lblBaslikYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikYazar.ForeColor = System.Drawing.Color.White;
            this.lblBaslikYazar.Location = new System.Drawing.Point(210, 37);
            this.lblBaslikYazar.Name = "lblBaslikYazar";
            this.lblBaslikYazar.Size = new System.Drawing.Size(207, 39);
            this.lblBaslikYazar.TabIndex = 0;
            this.lblBaslikYazar.Text = "YAZARLAR";
            // 
            // panelDataGridYazarlar
            // 
            this.panelDataGridYazarlar.Controls.Add(this.dataGridView1);
            this.panelDataGridYazarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridYazarlar.Location = new System.Drawing.Point(0, 130);
            this.panelDataGridYazarlar.Name = "panelDataGridYazarlar";
            this.panelDataGridYazarlar.Size = new System.Drawing.Size(658, 531);
            this.panelDataGridYazarlar.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmMevcutYazarBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 661);
            this.Controls.Add(this.panelDataGridYazarlar);
            this.Controls.Add(this.panelYazarlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMevcutYazarBilgisi";
            this.Load += new System.EventHandler(this.frmMevcutYazarBilgisi_Load);
            this.panelYazarlar.ResumeLayout(false);
            this.panelYazarlar.PerformLayout();
            this.panelDataGridYazarlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelYazarlar;
        private System.Windows.Forms.Label lblBaslikYazar;
        private System.Windows.Forms.Panel panelDataGridYazarlar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
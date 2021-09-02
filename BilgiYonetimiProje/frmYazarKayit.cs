using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYonetimiProje
{
    public partial class frmYazarKayit : Form
    {
        public frmYazarKayit()
        {
            InitializeComponent();
        }

        private void btnYazarKayit_Click(object sender, EventArgs e)
        {
            try
            {
                DATABASE db = new DATABASE();
                db.YazarINSERT(txtYazarAdi.Text, txtYazarSoyad.Text, txtTelNo.Text);
                MessageBox.Show("Yazar kaydı başarılı");
                txtTelNo.Text = "";
                txtYazarAdi.Text = "";
                txtYazarSoyad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                txtTelNo.Text = "";
                txtYazarAdi.Text = "";
                txtYazarSoyad.Text = "";
            }
            
        }
    }
}

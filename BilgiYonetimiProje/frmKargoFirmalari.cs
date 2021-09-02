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
    public partial class frmKargoFirmalari : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        public frmKargoFirmalari()
        {
            InitializeComponent();
            kargoFirmalariSELECT();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DATABASE db = new DATABASE();
                db.KargoINSERT(txtFirmaAdi.Text,txtKargoTelefon.Text);
                MessageBox.Show("Kargo Kaydı Başarılı");
                kargoFirmalariSELECT();
                txtFirmaAdi.Text = "";
                txtKargoTelefon.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void kargoFirmalariSELECT()
        {
            var kargoFirmalari = entity.KARGO
                .Select(x => new { x.FirmaAdı, x.FirmaTelefonNumarası })
                .ToList();
            dataGridView1.DataSource = kargoFirmalari;
        }
    }
}

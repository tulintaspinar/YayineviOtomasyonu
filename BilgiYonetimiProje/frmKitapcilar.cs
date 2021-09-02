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
    public partial class frmKitapcilar : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        DATABASE db = new DATABASE();
        public frmKitapcilar()
        {
            InitializeComponent();
        }

        private void frmKitapcilar_Load(object sender, EventArgs e)
        {
            KitapciSELECT();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KITAPCİLAR kitapci = new KITAPCİLAR();
                kitapci.Kitapci = txtKitapciAd.Text;
                kitapci.Adres = txtAdres.Text;
                kitapci.İl = txtİl.Text;
                kitapci.Telefon = txtTelefon.Text;

                db.KitapciINSERT(kitapci);
                KitapciSELECT();
                MessageBox.Show("Kitapevi kaydı oluşturuldu");
                txtAdres.Text="";
                txtKitapciAd.Text="";
                txtTelefon.Text = "";
                txtİl.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void KitapciSELECT()
        {
            try
            {
                var kitapcilar = entity.KITAPCİLAR.Select(x => new
                {
                    Kitapçı = x.Kitapci,
                    Adres = x.Adres,
                    İl = x.İl,
                    Telefon = x.Telefon
                }).ToList();
                dataGridKitapcilar.DataSource = kitapcilar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

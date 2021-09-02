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
    public partial class formGirisEkranı : Form
    {
        
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        DATABASE db = new DATABASE();
        string kullaniciAdi, sifre;
        public formGirisEkranı()
        {
            InitializeComponent();
        }

        private void formGirisEkranı_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var personel = entity.PERSONEL
                .Where(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text)
                .FirstOrDefault();
            if (personel != null)
            {
                bilgilerAl(txtKullaniciAdi.Text, txtSifre.Text);
                frmAnasayfa frmAnasayfa = new frmAnasayfa(txtKullaniciAdi.Text,txtSifre.Text);
                frmAnasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen bilgiler hatalı");
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmPersonelKayit kayit = new frmPersonelKayit();
            kayit.Show();
            this.Hide();
        }

        private void bilgilerAl(string ad,string sifre)
        {
            this.kullaniciAdi = ad;
            this.sifre = sifre;
        }
        public string personelBilgileri()
        {
            return this.kullaniciAdi + " " + this.sifre;
        }
    }
}

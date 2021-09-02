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
    public partial class frmPersonel : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        DATABASE db = new DATABASE();
        string kullaniciAdi, sifre;
        public frmPersonel(string a,string s)
        {
            this.kullaniciAdi = a;
            this.sifre = s;
            InitializeComponent();
            personelBilgiler();
            txtSifre.MaxLength = 8;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa frm = new frmAnasayfa(this.kullaniciAdi,this.sifre); frm.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var personel = entity.PERSONEL
                .Where(x => x.KullaniciAdi == this.kullaniciAdi && x.Sifre == this.sifre)
                .FirstOrDefault();
            
            if (txtSifre.Text != "********")
            {
                personel.PersonelSoyadi = txtSoyad.Text;
                personel.E_Mail = txtEmail.Text;
                personel.Sifre = txtSifre.Text;
                entity.SaveChanges();
            }
            else
            {
                personel.PersonelSoyadi = txtSoyad.Text;
                personel.E_Mail = txtEmail.Text;
                entity.SaveChanges();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSifre.Text = this.sifre;
            }
            else
            {
                txtSifre.Text = "********";
            }
        }

        private void personelBilgiler()
        {
            var personel = entity.PERSONEL
                .Where(x => x.KullaniciAdi == this.kullaniciAdi && x.Sifre == this.sifre)
                .FirstOrDefault();

            txtAd.Text = personel.PersonalAdi;
            txtSoyad.Text = personel.PersonelSoyadi;
            txtEmail.Text = personel.E_Mail;
            txtKullaniciAd.Text = personel.KullaniciAdi;
            if (checkBox1.Checked == true)
            {
                txtSifre.Text = personel.Sifre;
            }
            else
            {
                txtSifre.Text = "********";
            }
        }
    }
}

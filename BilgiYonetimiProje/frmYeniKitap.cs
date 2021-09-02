using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYonetimiProje
{
    public partial class frmYeniKitap : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        string dosyayolu;
        public frmYeniKitap()
        {
            InitializeComponent();
        }
        private void frmYeniKitap_Load(object sender, EventArgs e)
        {
            foreach (KITAPTURLERI pro in entity.KITAPTURLERI.ToList())
            {
                comboBoxKitapTuru.Items.Add(pro.KitapTuru);
            }
            foreach (YAZARLAR pro in entity.YAZARLAR.ToList())
            {
                comboboxYazar.Items.Add(pro.YazarAdi.Trim(' ')+" "+pro.YazarSoyadi);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();
            try
            {
                int isbnNo = Convert.ToInt32(txtISBNO.Text);
                string ad = txtKitapAdi.Text;
                DateTime tarih = dateTimeYayinTarihi.Value;
                int sayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);
                string tur = comboBoxKitapTuru.Text;
                string yazar = comboboxYazar.Text;
                string cevirmen = txtCevirmen.Text;
                db.KitapINSERT(isbnNo, ad, tarih, sayfaSayisi, tur, yazar, cevirmen,dosyayolu);
                MessageBox.Show("Kitap kaydı başarılı");
                txtISBNO.Text = "";
                txtKitapAdi.Text = "";
                txtSayfaSayisi.Text = "";
                txtCevirmen.Text = "";
                comboBoxKitapTuru.Text = "";
                comboboxYazar.Text = "";
                dateTimeYayinTarihi.Text = "";
                OnayMaili();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "PDF Dosyaları |*.pdf";
            dosya.ShowDialog();
            dosyayolu = dosya.FileName;
        }
        private void OnayMaili()
        {
            SmtpClient sc = new SmtpClient();
            sc.Credentials = new NetworkCredential("ybsTulinTaspinar@gmail.com", "123456YBS");
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("mhcalp@ktu.edu.tr", "TULPA YAYINEVİ");
            mail.To.Add(" mhcalp@ktu.edu.tr");
            //mail.To.Add("alici2@mail.com");
            mail.Subject = "TULPA YAYINEVİKİTAP ONAYI";
            mail.Body = "Kitabınız onaylanmıştır." +
                "****TULPA YAYINEVİ****";
            sc.Send(mail);
        }
    }
}

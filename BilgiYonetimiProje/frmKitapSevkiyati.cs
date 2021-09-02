using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYonetimiProje
{
    public partial class frmKitapSevkiyati : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        DATABASE db = new DATABASE();
        public frmKitapSevkiyati()
        {
            InitializeComponent();
            SevkiyatSELECT();
            KitapcilariSELECT();
            KitaplarSELECT();
            kargoFirmalariSELECT();
            yayıneviSELECT();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                var yayinevi = entity.YAYINEVISUBELERI
                    .Where(x => x.SubeAdi == cmboxYayınEvi.Text).FirstOrDefault();
                var kitapci = entity.KITAPCİLAR
                    .Where(x=>x.Kitapci == cmboxKitapci.Text ).FirstOrDefault();
                var kitap = entity.KITAP
                    .Where(x => x.KitapAdı == cmboxKitapAdi.Text).FirstOrDefault();
                var kargo = entity.KARGO
                    .Where(x => x.FirmaAdı == cmboxKargoFirmasi.Text).FirstOrDefault();

                int adet = Convert.ToInt32(txtKitapAdedi.Text);
                db.KitapSevkiyatINSERT(yayinevi.ID,kitapci.ID, kitap.ID, kargo.ID,adet);
                MessageBox.Show("Sevkiyat kaydı oluşturuldu.");
                SevkiyatSELECT();
                OnayMaili();
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            try
            {
                db.KitapSevkiyatDELETE(Convert.ToInt32(txtKargoNumarasi.Text));
                MessageBox.Show("İptal edildi");
                txtKargoNumarasi.Text = "";
                SevkiyatSELECT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SevkiyatSELECT()
        {
            var sevkiyat = entity.KITAPSEVKIYATI
                .Select(x => new {
                    Kitapçı = x.KITAPCİLAR.Kitapci,
                    KitapAdı= x.KITAP.KitapAdı,
                    x.KitapAdedi,
                    KargoFirması = x.KARGO.FirmaAdı,
                    x.KargoTakipNumarası,
                    x.GonderimDurumu})
                .ToList();
            dataGridSevkiyat.DataSource = sevkiyat;
        }
        private void yayıneviSELECT()
        {
            List<YAYINEVISUBELERI> yayınevi = entity.YAYINEVISUBELERI.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("KİTAPÇI ADI");
            foreach (YAYINEVISUBELERI yayınev in yayınevi) dt.Rows.Add(yayınev.SubeAdi);
            cmboxYayınEvi.ValueMember = dt.Columns[0].ColumnName;
            cmboxYayınEvi.DataSource = dt;
        }
        private void KitapcilariSELECT()
        {
            List<KITAPCİLAR> kitapcilar = entity.KITAPCİLAR.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("KİTAPÇI ADI");
            foreach (KITAPCİLAR kitapci in kitapcilar) dt.Rows.Add(kitapci.Kitapci);
            cmboxKitapci.ValueMember = dt.Columns[0].ColumnName;
            cmboxKitapci.DataSource = dt;
        }
        private void KitaplarSELECT()
        {
            List<KITAP> ktp = entity.KITAP.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("KİTAP ADI");
            foreach (KITAP kitap in ktp) dt.Rows.Add(kitap.KitapAdı);

            cmboxKitapAdi.ValueMember = dt.Columns[0].ColumnName;
            cmboxKitapAdi.DataSource = dt;
        }
        private void kargoFirmalariSELECT()
        {
            List<KARGO> krg = entity.KARGO.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("FİRMA ADI");
            foreach (KARGO kargo in krg) dt.Rows.Add(kargo.FirmaAdı);

            cmboxKargoFirmasi.ValueMember = dt.Columns[0].ColumnName;
            cmboxKargoFirmasi.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKargoNumarasi.Text = dataGridSevkiyat.CurrentRow.Cells[4].Value.ToString();
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
            mail.To.Add("mhcalp@ktu.edu.tr");
            //mail.To.Add("alici2@mail.com");
            mail.Subject = "TULPA YAYINEVİ KARGO BİLGİLENDİRMESİ";
            mail.Body = "TULPA YAYINEVİ "+cmboxYayınEvi.Text.Trim(' ')+" şubesinden "+cmboxKitapci.Text.Trim(' ')+"'ne gidecek kargo mevcuttur." +
                "" +
                "" +
                "****TULPA YAYINEVİ****";
            sc.Send(mail);
        }
    }
}

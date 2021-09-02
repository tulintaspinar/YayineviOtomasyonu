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
    public partial class frmPersonelKayit : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        public frmPersonelKayit()
        {
            InitializeComponent();
            List<YAYINEVISUBELERI> sube = entity.YAYINEVISUBELERI.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ŞUBE ADI");
            foreach (YAYINEVISUBELERI subeler in sube) dt.Rows.Add(subeler.SubeAdi);

            cmboboxSubeAdi.ValueMember = dt.Columns[0].ColumnName;
            cmboboxSubeAdi.DataSource = dt;
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            formGirisEkranı girisEkrani = new formGirisEkranı();
            girisEkrani.Show();
            this.Hide();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            int subeID = 0;
            string sifre = "";
            DateTime dt = this.dateTimePicker1.Value.Date;
            try
            {
                sifre = txtSifre.Text;
                var subeIDSelect = entity.YAYINEVISUBELERI
                                    .Where(x => x.SubeAdi == cmboboxSubeAdi.Text)
                                    .FirstOrDefault();
                subeID = subeIDSelect.ID;
                if (subeID != 0 && sifre.Length == 8)
                {
                    DATABASE db = new DATABASE();
                    db.PersonelINSERT(txtPersonelAd.Text, txtPersonelSoyad.Text,
                        txtTC.Text,txtEmail.Text, dt, subeID, txtKullaniciAdi.Text, sifre);
                    MessageBox.Show("Kayıt Başarılı");
                    txtPersonelAd.Text = "";
                    txtPersonelSoyad.Text = "";
                    txtTC.Text = "";
                    dateTimePicker1.Text = "";
                    cmboboxSubeAdi.Text = "";
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                }
                else if (cmboboxSubeAdi.Text == "")
                {
                    MessageBox.Show("Şube seçilmedi");
                }
                else if(sifre.Length>8)
                {
                    MessageBox.Show("Şifre 8 karakter olmalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

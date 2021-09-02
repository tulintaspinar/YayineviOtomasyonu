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
    public partial class frmMevcutKitap : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        public frmMevcutKitap()
        {
            InitializeComponent();
        }

        private void frmMevcutKitap_Load(object sender, EventArgs e)
        {
            var kitaplar = entity.KITAP.Select(x=> new { 
                x.ISBN_NO,
                x.KitapAdı,
                x.YayinTarihi,
                x.SayfaSayisi,
                KitapTürü=x.KITAPTURLERI.KitapTuru,
                YazarAdı=x.YAZARLAR.YazarAdi.TrimEnd()+" "+x.YAZARLAR.YazarSoyadi,
                Çevirmen=x.Çevirmen }).ToList();
            dataGridView1.DataSource = kitaplar;
        }
    }
}

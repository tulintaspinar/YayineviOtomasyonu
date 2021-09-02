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
    public partial class frmMevcutYazarBilgisi : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        public frmMevcutYazarBilgisi()
        {
            InitializeComponent();
        }

        private void frmMevcutYazarBilgisi_Load(object sender, EventArgs e)
        {
            YAZARLAR yazar = new YAZARLAR();
            var liste = entity.YAZARLAR.Select(x => new {x.YazarAdi,x.YazarSoyadi,x.Telefon_No }).ToList();
            dataGridView1.DataSource = liste;
        }
    }
}

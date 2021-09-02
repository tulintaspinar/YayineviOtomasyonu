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
    public partial class frmKitapTürleri : Form
    {
        BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        DATABASE db = new DATABASE();
        public frmKitapTürleri()
        {
            InitializeComponent();
            var turler = entity.KITAPTURLERI.Select(x => new { x.KitapTuru }).ToList();
            dtGridKitapTuru.DataSource = turler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                db.KitapTuruINSERT(txtKitapTuru.Text);
                var turler = entity.KITAPTURLERI.Select(x => new { x.KitapTuru }).ToList();
                dtGridKitapTuru.DataSource = turler;
                txtKitapTuru.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

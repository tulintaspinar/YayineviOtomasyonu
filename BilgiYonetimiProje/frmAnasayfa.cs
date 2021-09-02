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
    public partial class frmAnasayfa : Form
    {
        private Form activeForm = null;
        string kullanici, sifre;
        public frmAnasayfa(string a,string s)
        {
            this.kullanici = a;
            this.sifre = s;
            InitializeComponent();
            customizeDesing();
        }
        private void FormAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKitapAltMenu);
        }

        private void btnMevcutKitap_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmMevcutKitap());
        }
        private void btnYeniKitap_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmYeniKitap());
        }
        
        private void btnYazar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelYazarAltMenu);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmMevcutYazarBilgisi());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmYazarKayit());
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz ? ","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnKitapSevkiyatı_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmKitapSevkiyati());
        }
        private void btnKargo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmKargoFirmalari());
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnKitapTürü_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmKitapTürleri());
        }
        private void customizeDesing()
        {
            panelKitapAltMenu.Visible = false;
            panelYazarAltMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelKitapAltMenu.Visible == true)
                panelKitapAltMenu.Visible = false;
            if (panelYazarAltMenu.Visible == true)
                panelYazarAltMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnKitapcilar_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new frmKitapcilar());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPersonel frm = new frmPersonel(this.kullanici,this.sifre); frm.Show();
        }
    }
}

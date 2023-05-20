using DouYonetim.KullanıcıDenetimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DouYonetim
{
    public partial class YonetimPaneli : Form
    {
        
        KullanıcıDenetimi.EkleUC ekleUC = new EkleUC();
        KullanıcıDenetimi.GuncellestirUC guncellestirUC = new GuncellestirUC();
        KullanıcıDenetimi.AkademisyenSil akademisyenSil = new AkademisyenSil();
        KullanıcıDenetimi.İdariİzinEkle idariİzinEkle = new İdariİzinEkle();
        KullanıcıDenetimi.IzinEkleUC YillikİzinEkle = new IzinEkleUC();
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void YonetimPaneli_Load(object sender, EventArgs e)
        {
            isrtbtn.Visible= false;
        }

        private void cksbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            Secim_Ekranı secim_Ekran = new Secim_Ekranı();
            secim_Ekran.Show();
            this.Close();
        }

        private void akademisyenekle_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(20, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(ekleUC);
        }

        private void gnclleakademisyen_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(321, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(guncellestirUC);
        }

        private void akademisyensil_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(171, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(akademisyenSil);
        }

        private void yizinekle_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(473, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(YillikİzinEkle);
        }

        private void iizinekle_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(624,45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(idariİzinEkle);
        }
    }
}

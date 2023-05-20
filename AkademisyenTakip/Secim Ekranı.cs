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
    public partial class Secim_Ekranı : Form
    {
        AnaSayfa anaSayfa  = new AnaSayfa();
        YonetimPaneli yonetimPaneli = new YonetimPaneli();
        public Secim_Ekranı()
        {
            InitializeComponent();
        }
        private void anasyf_btn_Click(object sender, EventArgs e)
        {
            anaSayfa.Show();
            this.Hide();
        }

        private void yonetm_panel_Click(object sender, EventArgs e)
        {
            yonetimPaneli.Show();
            this.Hide();
        }
    }
}

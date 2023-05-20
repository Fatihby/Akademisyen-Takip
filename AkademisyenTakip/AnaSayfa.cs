using DouYonetim.KullanıcıDenetimi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DouYonetim
{
    public partial class AnaSayfa : Form
    {
        KullanıcıDenetimi.GunBazliArama gunBazli = new GunBazliArama();
        KullanıcıDenetimi.ProgramBazlıArama programBazlı = new ProgramBazlıArama();
       KullanıcıDenetimi.araUC ara = new araUC();
        KullanıcıDenetimi.TariheGoreArama tariheGore = new TariheGoreArama();
        DataBaseClass dbclass = new DataBaseClass();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            isrtbtn.Visible = false;
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            Secim_Ekranı scm = new Secim_Ekranı();
            scm.Show();
            this.Close();
        }

        private void formbuyultstart_Tick(object sender, EventArgs e)
        {
            
        }

        private void cksbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void gnbzli_btn_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(20, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(gunBazli);
            usercontrl.Width = gunBazli.Width;
            usercontrl.Height = gunBazli.Height;
        }

        private void dsu_btn_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(322, 45);
        }

        private void prgrmbaz_btn_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(221, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(programBazlı);
            usercontrl.Width = programBazlı.Width;
            usercontrl.Height = programBazlı.Height;
        }

        private void adara_btn_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(422, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(ara);
            usercontrl.Width = ara.Width;
            usercontrl.Height = ara.Height;
        }

        private void tariharamabtn_Click(object sender, EventArgs e)
        {
            isrtbtn.Visible = true;
            isrtbtn.Location = new System.Drawing.Point(622, 45);
            usercontrl.Controls.Clear();
            usercontrl.Controls.Add(tariheGore);
            usercontrl.Width = tariheGore.Width;
            usercontrl.Height = tariheGore.Height;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DouYonetim.KullanıcıDenetimi
{
    public partial class GuncellestirUC : UserControl
    {
        string  ad, soyad;
        string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
        ArrayList id = new ArrayList();
        public GuncellestirUC()
        {
            InitializeComponent();
        }

        private void gncl_btn_Click(object sender, EventArgs e)
        {
            DataBaseClass dbclass = new DataBaseClass();
            string id = "";
            dbclass.con = new SqlConnection(dbclass.constring);
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("update OgretmenBilgileri set Ad=@Ad,Soyad=@Soyad,TelNo=@TelNo,MailAdresi=@MailAdresi,FK_BolumID=@BolumID,AIGun=@aigun where ID=" + idtxtbox.Text, dbclass.con);
            dbclass.com.Parameters.AddWithValue("@Ad", ad_txtbox.Text);
            dbclass.com.Parameters.AddWithValue("@Soyad", soyad_txtbox.Text);
            dbclass.com.Parameters.AddWithValue("@TelNo", telno_txtbox.Text);
            dbclass.com.Parameters.AddWithValue("@MailAdresi", mailadresi_txtbox.Text);
            dbclass.com.Parameters.AddWithValue("@BolumID", bolumcombobox.SelectedIndex+1);
            if (aiguncombobox.SelectedIndex >= 0 && aiguncombobox.SelectedIndex<5)
            {
                dbclass.com.Parameters.AddWithValue("@aigun", gunler[aiguncombobox.SelectedIndex]);
            }
            dbclass.com.ExecuteNonQuery();
            dbclass.con.Close();
        }
        private void bolumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aiguncombobox.Items.Clear();
            akademisyencombo.Items.Clear();
            id.Clear();
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            for (int i = 0; i < 5; i++)
            {
                int sayac = 0;
                dbclass.com = new SqlCommand("Select * from OgretmenBilgileri where AIGun = @aigun and FK_BolumID = @bolumid", dbclass.con);
                dbclass.com.Parameters.AddWithValue("@aigun", gunler[i]);
                dbclass.com.Parameters.AddWithValue("@bolumid", Convert.ToInt16(bolumcombobox.SelectedIndex + 1));
                SqlDataReader dr = dbclass.com.ExecuteReader();
                if (dr.Read())
                {
                    sayac++;
                }
                dr.Close();
                aiguncombobox.Items.Add(gunler[i] + " (" + sayac + ")");
            }
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("SELECT * from OgretmenBilgileri where FK_BolumID=" + (bolumcombobox.SelectedIndex+1), dbclass.con);
            SqlDataReader dr2 = dbclass.com.ExecuteReader();
            while (dr2.Read())
            {
                id.Add(dr2["ID"].ToString());
                ad = dr2["Ad"].ToString();
                soyad = dr2["Soyad"].ToString();
                akademisyencombo.Items.Add(dr2["ID"].ToString()+") "+ad+" "+soyad);
                
            }
            dr2.Close();
            dbclass.con.Close();
        }

        private void GuncellestirUC_Load(object sender, EventArgs e)
        {
            idtxtbox.Enabled = false;
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            AnaSayfa anasayfa = new AnaSayfa();
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("SELECT * from Bolumler", dbclass.con);
            SqlDataReader dr2 = dbclass.com.ExecuteReader();
            while (dr2.Read())
            {
                string a = dr2["BolumAd"].ToString();
                bolumcombobox.Items.Add(a);
            }
            dr2.Close();
            dbclass.con.Close();
        }

        private void akademisyencombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("SELECT * from OgretmenBilgileri where ID=" + id[akademisyencombo.SelectedIndex], dbclass.con);
            SqlDataReader dr2 = dbclass.com.ExecuteReader();
            if (dr2.Read())
            {
                 idtxtbox.Text = id[akademisyencombo.SelectedIndex].ToString();
                 ad_txtbox.Text = dr2["Ad"].ToString();
                 soyad_txtbox.Text = dr2["Soyad"].ToString();
                 telno_txtbox.Text = dr2["TelNo"].ToString();
                 mailadresi_txtbox.Text = dr2["MailAdresi"].ToString();
                 aiguncombobox.Text = dr2["AIGun"].ToString();
            }
        }
    }
}
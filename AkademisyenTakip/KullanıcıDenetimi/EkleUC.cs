using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DouYonetim.KullanıcıDenetimi
{
    public partial class EkleUC : UserControl
    {
        public EkleUC()
        {
            InitializeComponent();
        }
        string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
        public UserControl ParentControl { get; set; }
        DataBaseClass dbclass = new DataBaseClass();
        private void EkleUC_Load(object sender, EventArgs e)
        {
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            SqlDataAdapter da1 = new SqlDataAdapter(dbclass.com);
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

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            bool kontrol = false;
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("Select * from  OgretmenBilgileri where ID =" + idtxtbox.Text,dbclass.con);
            SqlDataReader dr = dbclass.com.ExecuteReader();
            if (dr.Read())
            {
                kontrol = true;
            }
            dr.Close();
            if (kontrol == false)
            {
                dbclass.com = new SqlCommand("INSERT INTO  OgretmenBilgileri(ID,Ad,Soyad,TelNo,MailAdresi,BaslangicTarihi,FK_BolumID,AIGun,KullanılanIzinGunu,KullanılanIdariIzin) VALUES (@id,@Ad,@Soyad,@TelNo,@MailAdresi,@BaslangicTarihi,@FK_BolumID,@AIGun,0,0)", dbclass.con);
                dbclass.com.Parameters.AddWithValue("@id", idtxtbox.Text);
                dbclass.com.Parameters.AddWithValue("@Ad", ad_txtbox.Text);
                dbclass.com.Parameters.AddWithValue("@Soyad", soyad_txtbox.Text);
                dbclass.com.Parameters.AddWithValue("@TelNo", telno_txtbox.Text);
                dbclass.com.Parameters.AddWithValue("@MailAdresi", mailadresi_txtbox.Text);
                dbclass.com.Parameters.AddWithValue("@BaslangicTarihi", isebaslangic.Value.ToString("yyyy-MM-dd"));
                dbclass.com.Parameters.AddWithValue("@FK_BolumID", bolumcombobox.SelectedIndex + 1);
                dbclass.com.Parameters.AddWithValue("@AIGun", gunler[aiguncombobox.SelectedIndex]);
                dbclass.com.ExecuteNonQuery();
            }
            else MessageBox.Show("Bu ID bir akademisyen tarafından kullanılıyor.");
            dbclass.con.Close();
        }
        private void bolumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aiguncombobox.Items.Clear();
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
            
        }
    }
}

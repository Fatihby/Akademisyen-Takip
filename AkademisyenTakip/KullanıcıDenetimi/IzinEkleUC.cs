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
    public partial class IzinEkleUC : UserControl
    {

        public IzinEkleUC()
        {
            InitializeComponent();
        }

        private void iekle_btn_Click(object sender, EventArgs e)
        {
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            string oid = "";
            bool kontrol = false;
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("Select * from OgretmenBilgileri where Ad='" + ad_txtbox.Text + "'and Soyad='" + soyad_txtbox.Text + "'", dbclass.con);
            SqlDataReader dr2 = dbclass.com.ExecuteReader();
            if (dr2.Read())
            {
                oid = dr2["ID"].ToString();
            }

            dbclass.com = new SqlCommand("Select * from Izinler where ID=" + oid, dbclass.con);
            if (dr2.Read())
            {
                MessageBox.Show("Akademisyen izni mevcut.");
            }
            else
            {
                kontrol = true;
            }
            dr2.Close();
            if(kontrol == true) dbclass.com = new SqlCommand("INSERT INTO Izinler(ID,BaTarihi,BiTarihi) values('" + oid+"','" + izinbslngc.Value.ToString("yyyy-MM-dd") + "','" + izinbts.Value.ToString("yyyy-MM-dd") + "','" + oid + "')", dbclass.con);
            dbclass.com.ExecuteNonQuery();
            dbclass.con.Close();
        }

        private void İzinEkle_Load(object sender, EventArgs e)
        {
            ArrayList id = new ArrayList();
            ArrayList gün = new ArrayList();
            izinbslngc.Value = DateTime.Now;
            izinbts.Value = DateTime.Now;
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            if (dbclass.con.State== ConnectionState.Closed) 
                dbclass.con.Open();
            dbclass.com = new SqlCommand("SELECT i.ID,DATEDIFF(day,i.BaTarihi,İ.BiTarihi) as Gün FROM Izinler i WHERE i.BiTarihi<@tarih",dbclass.con);
            dbclass.com.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd"));
            SqlDataReader dr = dbclass.com.ExecuteReader();
            if (dr.Read())
            {
                id.Add(dr["ID"].ToString());
                gün.Add(dr["Gün"].ToString());
            }
            dr.Close();
            dbclass.com = new SqlCommand("Delete From Izinler where BiTarihi<@tarih", dbclass.con);
            dbclass.com.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd"));
            dbclass.com.ExecuteNonQuery();
            for (int i = 0; i < id.Count; i++)
            {
                 dbclass.com = new SqlCommand("update OgretmenBilgileri set KullanılanIzinGunu=@kigun where ID=@id", dbclass.con);
                dbclass.com.Parameters.AddWithValue("@kigun", gün[i]);
                dbclass.com.Parameters.AddWithValue("@id", id[i]);
                dbclass.com.ExecuteNonQuery();
            }
            dbclass.con.Close();
        }
    }
}

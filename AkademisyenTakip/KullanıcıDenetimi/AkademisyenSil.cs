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
    public partial class AkademisyenSil : UserControl
    {
        public AkademisyenSil()
        {
            InitializeComponent();
        }
        ArrayList id = new ArrayList();
        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (akademisyencombo.SelectedIndex >= 0 && akademisyencombo.SelectedIndex < id.Count)
            {
                    int selectedId = Convert.ToInt32(id[akademisyencombo.SelectedIndex]);

                    DataBaseClass dbclass = new DataBaseClass();
                    dbclass.con = new SqlConnection(dbclass.constring);

                    if (dbclass.con.State == ConnectionState.Closed)
                        dbclass.con.Open();

                    dbclass.com = new SqlCommand("DELETE FROM DersBilgileri WHERE OgretmenID = @id", dbclass.con);
                    dbclass.com.Parameters.AddWithValue("@id", selectedId);
                    dbclass.com.ExecuteNonQuery();

                    dbclass.com = new SqlCommand("DELETE FROM OgretmenBilgileri WHERE ID = @id", dbclass.con);
                    dbclass.com.Parameters.AddWithValue("@id", selectedId);
                    dbclass.com.ExecuteNonQuery();

                    dbclass.com = new SqlCommand("DELETE FROM Izinler WHERE ID = @id", dbclass.con);
                    dbclass.com.Parameters.AddWithValue("@id", selectedId);
                    dbclass.com.ExecuteNonQuery();

                    dbclass.com = new SqlCommand("DELETE FROM IdariIzin WHERE ID = @id", dbclass.con);
                    dbclass.com.Parameters.AddWithValue("@id", selectedId);
                    dbclass.com.ExecuteNonQuery();

                    dbclass.con.Close();


            }

            akademisyencombo.Text = "Akademisyen Seçiniz.";


        }

        private void bolumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            akademisyencombo.Items.Clear();
            akademisyencombo.Text = "Akademisyen Seçiniz.";
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("SELECT * from OgretmenBilgileri where FK_BolumID=" + (bolumcombobox.SelectedIndex + 1), dbclass.con);
            SqlDataReader dr2 = dbclass.com.ExecuteReader();
            while (dr2.Read())
            {
                id.Add(dr2["ID"].ToString());
                akademisyencombo.Items.Add(dr2["ID"].ToString() + ") " + dr2["Ad"].ToString() + " " + dr2["Soyad"].ToString());
            }
            dbclass.con.Close();
        }

        private void AkademisyenSil_Load(object sender, EventArgs e)
        {
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
    }
}

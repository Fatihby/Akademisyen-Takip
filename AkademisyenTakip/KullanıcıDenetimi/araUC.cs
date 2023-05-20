using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DouYonetim.KullanıcıDenetimi
{
    public partial class araUC : UserControl
    {
        class Akademisyen
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string TelNo { get; set; }
            public string MailAdresi { get; set; }
            public string AIGun { get; set; }
            public string BasTar { get; set; }
            public string BitTar { get; set; }
        }
        private void bilgi_dgrid_Click(object sender, EventArgs e)
        {

        }
        private void AraUC_Load(object sender, EventArgs e)
        {

        }
        private void bilgi_dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public araUC()
        {
            InitializeComponent();
        }

        private void bul_btn_Click(object sender, EventArgs e)
        {
            List<Akademisyen> persons;
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            SqlDataAdapter da = new SqlDataAdapter(dbclass.com);
            string bastar = " ";
            string Bittar = " ";
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            string query = "SELECT Ad, Soyad, TelNo, MailAdresi, AIGun " +
                   "FROM OgretmenBilgileri " +
                   "WHERE Ad = @ad AND Soyad = @soyad";
            dbclass.com = new SqlCommand(query, dbclass.con);
            dbclass.com.Parameters.AddWithValue("@ad", ad_txtbox.Text);
            dbclass.com.Parameters.AddWithValue("@soyad", soyad_txtbox.Text);
            SqlDataReader dr = dbclass.com.ExecuteReader();
            persons = new List<Akademisyen>();
            if (dr.Read())
            {
                persons.Add(new Akademisyen()
                {
                    Ad = dr["Ad"].ToString(),
                    Soyad = dr["Soyad"].ToString(),
                    TelNo = dr["Telno"].ToString(),
                    MailAdresi = dr["MailAdresi"].ToString(),
                    AIGun = dr["AIGun"].ToString()
                });
            }
            dr.Close();
            query = "SELECT BaTarihi, BiTarihi " +
                  "FROM Izinler " +
                  "WHERE ID = (SELECT ID FROM OgretmenBilgileri WHERE Ad = @ad AND Soyad = @soyad)";
            dbclass.com = new SqlCommand(query, dbclass.con);
            dbclass.com.Parameters.AddWithValue("@ad", ad_txtbox.Text);
            dbclass.com.Parameters.AddWithValue("@soyad", soyad_txtbox.Text);
            SqlDataReader dr1 = dbclass.com.ExecuteReader();
            if (dr1.Read())
            {
                persons[0].BasTar = dr["BaTarihi"].ToString();
                persons[0].BitTar = dr["BiTarihi"].ToString();
            }    
            bilgi_dgrid.DataSource = persons;
            dbclass.con.Close();
        }
    }
}


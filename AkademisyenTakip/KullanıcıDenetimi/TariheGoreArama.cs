using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DouYonetim.KullanıcıDenetimi
{
    public partial class TariheGoreArama : UserControl
    {
        public TariheGoreArama()
        {
            InitializeComponent();
        }
        class Akademisyen
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string TelNo { get; set; }
            public string MailAdresi { get; set; }
            public string BaslangicTarihi { get; set; }
            public string Bolumad { get; set; }
        }
        private void gosterbtn_Click(object sender, EventArgs e)
        {
            List<Akademisyen> persons = new List<Akademisyen>();
            HashSet<string> oid = new HashSet<string>();

            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            SqlDataAdapter da = new SqlDataAdapter(dbclass.com);

            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();

            dbclass.com = new SqlCommand("SELECT DISTINCT o.ID FROM OgretmenBilgileri o INNER JOIN Izinler i ON o.ID != i.ID OR (i.BaTarihi < @ibatarihi AND i.BiTarihi > @ibitarihi)", dbclass.con);
            dbclass.com.Parameters.AddWithValue("@ibatarihi", bslngc.Value.ToString("yyyy-MM-dd"));
            dbclass.com.Parameters.AddWithValue("@ibitarihi", bts.Value.ToString("yyyy-MM-dd"));
            SqlDataReader dr = dbclass.com.ExecuteReader();

            while (dr.Read())
            {
                oid.Add(dr["ID"].ToString());
            }
            dr.Close();

            if (oid.Count > 0)
            {
                string idList = string.Join(",", oid.Select(id => "'" + id + "'"));
                dbclass.com = new SqlCommand("SELECT o.Ad, o.Soyad, o.TelNo, o.MailAdresi, o.BaslangicTarihi, b.BolumAd FROM OgretmenBilgileri o INNER JOIN Bolumler b ON b.ID = o.FK_BolumID WHERE o.ID IN (" + idList + ")", dbclass.con);
                SqlDataReader dr2 = dbclass.com.ExecuteReader();

                while (dr2.Read())
                {
                    persons.Add(new Akademisyen()
                    {
                        Ad = dr2["Ad"].ToString(),
                        Soyad = dr2["Soyad"].ToString(),
                        TelNo = dr2["TelNo"].ToString(),
                        MailAdresi = dr2["MailAdresi"].ToString(),
                        BaslangicTarihi = dr2["BaslangicTarihi"].ToString(),
                        Bolumad = dr2["BolumAd"].ToString(),
                    });
                }

                dr2.Close();
            }

            tablo.DataSource = persons;
            dbclass.con.Close();




        }
    }
}

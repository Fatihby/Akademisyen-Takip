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
using System.Collections;
using System.Reflection;

namespace DouYonetim.KullanıcıDenetimi
{

    public partial class GunBazliArama : UserControl
    {
        public GunBazliArama()
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
            List<Akademisyen> persons;
            ArrayList oid= new ArrayList();
            ArrayList oid2 = new ArrayList();
            ArrayList oid3 = new ArrayList();
            ArrayList oid4 = new ArrayList();
            ArrayList oid5 = new ArrayList();
            oid.Clear();
            oid2.Clear();
            oid3.Clear();
            oid4.Clear();
            oid5.Clear();
            DataBaseClass dbclass = new DataBaseClass();
            dbclass.con = new SqlConnection(dbclass.constring);
            SqlDataAdapter da = new SqlDataAdapter(dbclass.com);
            //OgretmenBilgileri o,Izinler i,IdariIzin id,DersBilgileri db tablolarından 
            if (dbclass.con.State == ConnectionState.Closed)
                dbclass.con.Open();
            dbclass.com = new SqlCommand("SELECT o.ID FROM OgretmenBilgileri o LEFT JOIN Izinler  i ON (i.ID = o.ID and (i.BaTarihi < @ibatarihi or i.BiTarihi > @ibitarihi)) ", dbclass.con);
            dbclass.com.Parameters.AddWithValue("@ibatarihi", DateTime.Now.ToString("yyyy-MM-dd"));
            dbclass.com.Parameters.AddWithValue("@ibitarihi", DateTime.Now.ToString("yyyy-MM-dd"));
            SqlDataReader dr = dbclass.com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("OİD Read İçerisi.");
                oid.Add(dr["ID"].ToString());
            }
            dr.Close();
            for (int i = 0; i < oid.Count; i++)
            {
                dbclass.com = new SqlCommand("SELECT o.ID FROM OgretmenBilgileri o LEFT JOIN IdariIzin id ON id.Id = o.ID WHERE (id.IzinGun != 'Salı' OR id.IzinGun IS NULL) AND o.ID = @oid", dbclass.con);
                dbclass.com.Parameters.AddWithValue("@iizingun", guncombobox.Text);
                dbclass.com.Parameters.AddWithValue("@oid", oid[i].ToString());
                SqlDataReader dr2 = dbclass.com.ExecuteReader();
                if (dr2.Read())
                {
                    Console.WriteLine("OİD2 Read İçerisi.");
                    oid2.Add(dr2["ID"].ToString());
                }
                dr2.Close();

            }
            for (int i = 0; i < oid2.Count; i++)
            {
                dbclass.com = new SqlCommand("SELECT * FROM OgretmenBilgileri WHERE AIGun <> @aigun AND ID = @oid", dbclass.con);
                dbclass.com.Parameters.AddWithValue("@aigun", guncombobox.Text);
                dbclass.com.Parameters.AddWithValue("@oid", oid2[i].ToString());
                SqlDataReader dr3 = dbclass.com.ExecuteReader();
                if (dr3.Read())
                {
                    Console.WriteLine("OİD3 Read İçerisi.");
                    oid3.Add(dr3["ID"].ToString());
                }
                dr3.Close();
            }
            if (saattxtbxonoff.Checked == true)
            {
                for (int i = 0; i < oid3.Count; i++)
                {
                    dbclass.com = new SqlCommand("SELECT o.ID, o.Ad, o.Soyad FROM OgretmenBilgileri o INNER JOIN DersBilgileri db ON db.OgretmenID = o.ID AND db.DersGun = @dersgun WHERE o.ID = @oid AND (   (db.DersBas NOT BETWEEN @dersbas AND @dersbit) AND (db.DersBit NOT BETWEEN @dersbas AND @dersbit) OR     db.DersBas IS NULL OR db.DersBit IS NULL)", dbclass.con);
                    dbclass.com.Parameters.AddWithValue("@dersbas", bassaat.Text);
                    dbclass.com.Parameters.AddWithValue("@dersbit", bitsaat.Text);
                    dbclass.com.Parameters.AddWithValue("@oid", oid3[i]);
                    dbclass.com.Parameters.AddWithValue("@dersgun", guncombobox.Text);
                    SqlDataReader dr4 = dbclass.com.ExecuteReader();
                    if (dr4.Read())
                    {
                        Console.WriteLine("OİD4 Read İçerisi.");
                        oid4.Add(dr4["ID"]);
                    }
                    dr4.Close();
                }
            }
            else
            {
                for (int i = 0; i < oid3.Count; i++)
                {
                    dbclass.com = new SqlCommand("SELECT * FROM OgretmenBilgileri o INNER JOIN DersBilgileri db ON db.OgretmenID = o.ID AND db.DersGun = @dersgun WHERE o.ID = @oid", dbclass.con);
                    dbclass.com.Parameters.AddWithValue("@oid", oid3[i]);
                    dbclass.com.Parameters.AddWithValue("@dersgun", guncombobox.Text);
                    SqlDataReader dr4 = dbclass.com.ExecuteReader();
                    if (dr4.Read())
                    {
                        Console.WriteLine("OİD4 Read İçerisi.");
                        oid4.Add(dr4["ID"]);
                    }
                    dr4.Close();
                }
            }
            persons = new List<Akademisyen>();
            for (int i = 0; i < oid4.Count; i++)
            {
                dbclass.com = new SqlCommand("SELECT o.Ad, o.Soyad, o.TelNo, o.MailAdresi, o.BaslangicTarihi, b.BolumAd FROM OgretmenBilgileri o INNER JOIN Bolumler b ON b.ID = o.FK_BolumID WHERE o.ID = @oid", dbclass.con);
                dbclass.com.Parameters.AddWithValue("@oid", oid4[i]);
                SqlDataReader dr5 = dbclass.com.ExecuteReader();
                if (dr5.Read())
                {
                    Console.WriteLine("OİD5 Read İçerisi.");
                    persons.Add(new Akademisyen()
                    {
                        Ad = dr5["Ad"].ToString(),
                        Soyad = dr5["Soyad"].ToString(),
                        TelNo = dr5["Telno"].ToString(),
                        MailAdresi = dr5["MailAdresi"].ToString(),
                        BaslangicTarihi = dr5["BaslangicTarihi"].ToString(),
                        Bolumad = dr5["BolumAd"].ToString(),
                    });
                }
                dr5.Close();
            }
            tablo.DataSource = persons;
            dbclass.con.Close();
        }
        private void saattxtbxonoff_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (saattxtbxonoff.Checked == true)
            {
                bassaat.Enabled = true;
                bitsaat.Enabled = true;
            }
            else
            {
                bassaat.Enabled = false;
                bitsaat.Enabled = false;
            }
        }
    }
}

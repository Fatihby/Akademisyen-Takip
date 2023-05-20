using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DouYonetim
{
    internal class DataBaseClass
    {
        public string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + "C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\AKADEMISYENTAKIP.MDF";
        //public string constring = "Data Source=B1-74_58PC12361\\SQLEXPRESS01;Initial Catalog=AkademisyenTakip;Integrated Security=True";
        public SqlConnection con = new SqlConnection();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommand com = new SqlCommand();
        public DataSet ds = new DataSet();
    }
}

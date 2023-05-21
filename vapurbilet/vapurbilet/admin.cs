using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vapurbilet
{
    public partial class admin : Form
    {
        

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            SQLiteConnection baglanti =
        new SQLiteConnection
        ("Data Source=C:\\Users\\Yiğit\\PROJELER\\adimn.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("SELECT giris.tc,giriş.ad,giriş.soyad,seyahatler.kalkış,seyahatler.varış,seyahatler.saat FROM giris,seyahatler WHERE giris.tc = seyahatler.tc,giris.ad = seyahatler.ad,giris.soyad = seyahatler.soyad");
            DataSet ds = new DataSet();
            object value = (ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            baglanti.Close();
        }
    }
}

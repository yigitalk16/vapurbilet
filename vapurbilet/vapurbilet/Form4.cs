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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vapurbilet
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            long yas = Convert.ToInt32(textBox3.Text);
            long tel = Convert.ToInt32(textBox4.Text);
            string cinsiyet = comboBox1.Text;
            SQLiteConnection baglanti =
                new SQLiteConnection
                ("Data Source=C:\\Users\\Yiğit\\PROJELER\\giriş.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("DELETE FROM giris WHERE numara=('" + ad + "','" + soyad + "','" + yas + "','" +tel + "','" + cinsiyet + "')", baglanti);
            MessageBox.Show("kaydınız başarıyla silinmiştir");
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kalkıs = comboBox2.Text;
            string varıs = comboBox3.Text;
            string saat = comboBox4.Text;
            SQLiteConnection baglanti =
                new SQLiteConnection
                ("Data Source=C:\\Users\\Yiğit\\PROJELER\\giriş.db;version=3");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("DELETE FROM giris WHERE numara=('" + kalkıs + "','" + varıs + "','" + saat + "')", baglanti);
            MessageBox.Show("bilet kaydınız başarıyla silinmiştir");
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}

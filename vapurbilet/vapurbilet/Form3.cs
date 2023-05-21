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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglanti =
           new SQLiteConnection
           ("Data Source=C:\\Users\\Yiğit\\PROJELER\\giriş.db;version=3");
            baglanti.Open();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("ad boş bırakılamaz");
            }
            else
            {

                string ad = textBox1.Text;
                string soyad = textBox2.Text;
                long yas = Convert.ToInt32(textBox3.Text);
                long tel = Convert.ToInt32(textBox6.Text);
                string cinsiyet = comboBox5.Text;

                SQLiteCommand komut = new SQLiteCommand("INSERT INTO giris (ad,soyad,yas,tel,cinsiyet) VALUES ('" + ad + "','" + soyad + "','" + yas + "','" + tel + "','" + cinsiyet + "')", baglanti);
                MessageBox.Show("kaydınız başarıyla eklenmiştir");
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                Console.ReadLine();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SQLiteConnection baglanti =
           new SQLiteConnection
           ("Data Source=C:\\Users\\Yiğit\\PROJELER\\giriş.db;version=3");
            baglanti.Open();

            if (String.IsNullOrEmpty(comboBox6.Text))
            {
                MessageBox.Show("kalkış yeri boş bırakılamaz");
            }
            else if (String.IsNullOrEmpty(comboBox7.Text))
            {
                MessageBox.Show("varış yeri boş bırakılamaz");
            }
            else if (String.IsNullOrEmpty(comboBox8.Text))
            {
                MessageBox.Show("saat yeri boş bırakılamaz");
            }
            else
            {
                string kalkıs = comboBox6.Text;
                string varıs = comboBox7.Text;
                string saat = comboBox8.Text;
                SQLiteCommand komut2 = new SQLiteCommand("INSERT INTO seyahatler (kalkış,varış,saat) VALUES ('" + kalkıs + "','" + varıs + "','" + saat + "')", baglanti);
                komut2.Connection = baglanti;
                komut2.ExecuteNonQuery();
                MessageBox.Show("bilet kaydı başarıyla eklenmiştir");
                Console.ReadLine();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        
    }
}

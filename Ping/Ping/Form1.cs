using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


//SERDAR KARACA
//serdarkaraca13@gmail.com


namespace Ping
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static bool PingTest(string ipadress)
        {
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingReply pingStatus = ping.Send(IPAddress.Parse(ipadress), 1000);

            if (pingStatus.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (PingTest(listBox1.Items[i].ToString()) == false)
                {
                    //MessageBox.Show(listBox1.Items[i].ToString());
                }

                //*******************İSTERSENİZ SONUÇLARI SQL DB YE KAYIT EDEBİLİRSİNİZ.


                //SqlCommand sorgu = new SqlCommand();
                //baglan.Open();
                //sorgu.Connection = baglan;
                //sorgu.CommandText = "insert into SunucuDurumu (SunucuIP, Durumu) values (@p1, @p2)";
                //sorgu.Parameters.AddWithValue("@p1", listBox1.Items[i].ToString());
                //sorgu.Parameters.AddWithValue("@p2", PingTest(listBox1.Items[i].ToString()));
                //sorgu.ExecuteNonQuery();
                //baglan.Close();

                //*******************İSTERSENİZ SONUÇLARI SQL DB YE KAYIT EDEBİLİRSİNİZ.

                
                //MessageBox.Show(listBox1.Items[i].ToString() + " ->" + PingTest(listBox1.Items[i].ToString()).ToString());

                list_Sonuc.Items.Add(listBox1.Items[i].ToString() + " -> " + PingTest(listBox1.Items[i].ToString())).ToString();


            }
            MessageBox.Show("Ping Bitti");
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_IpAdress.Text);
        }

    }
}

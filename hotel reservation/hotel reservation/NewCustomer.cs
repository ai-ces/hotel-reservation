using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hotel_reservation
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection("connection string here");

        private void button2_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "109";
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kirmizi renkli butonlar dolu odalari gosterir");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yesil renkli butonlar bos odalari gosterir");
        }

        private void dTpCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dTpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dTpCikis.Text);

            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtAdi.Text + "', '" + txtSoyAdi.Text+"', '" + comboBox1.Text + "', '" +mtxtTelefon.Text +"', '" +txtEmail.Text + "', '" +txtOdaNumarasi.Text + "', '" +txtUcret.Text + "', '" + dTpGiris.Text +"', '" +dTpCikis.Text+"' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri kaydi yapildi");
        }
    }
}




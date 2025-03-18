using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev21_12
{
    public partial class Form1 : Form
    {
        Form2 SecimIslemi = new Form2();
        Form4 DukkanIslemleri = new Form4();
        public Form1()
        {
            InitializeComponent();
        }
        public static KasaGorevlisi yeniKasiyer = new KasaGorevlisi();
        public static KasaGorevlisi GirisYapanKasaGorevlisi = new KasaGorevlisi();
        public static KasaGorevlisi KasaGorevlisi1 = new KasaGorevlisi("Hasan", "Arslan", "1", 53779383690);
        public static KasaGorevlisi KasaGorevlisi2 = new KasaGorevlisi("İsa", "Arslan", "2", 5077379364);
        public static KasaGorevlisi KasaGorevlisi3 = new KasaGorevlisi("Tuğçe", "Bölükbaş", "3", 5418513194);
        public static KasaGorevlisi KasaGorevlisi4 = new KasaGorevlisi("Selahattin", "Arslan", "4", 5413213194);

        private void btnKasiyerGiris_Click(object sender, EventArgs e)
        {
            GirisYapanKasaGorevlisi.Ad = txtKasiyerAd.Text.ToUpper();
            GirisYapanKasaGorevlisi.Soyad = txtKasiyerSoyadi.Text.ToUpper();
            GirisYapanKasaGorevlisi.SigortaNo = txtSigortaNo.Text.ToUpper();


            if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi1.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi1.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi1.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi2.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi2.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi2.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi3.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi3.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi3.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi4.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi4.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi4.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Kasiyer Bilgileri Yanlış. Lütfen Tekrar Deneyin.");
                txtKasiyerAd.Text = "";
                txtKasiyerSoyadi.Text = "";
                txtSigortaNo.Text = "";
            }


        }


    }

}
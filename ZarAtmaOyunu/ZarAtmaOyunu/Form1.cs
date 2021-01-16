using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Bu oyunda iki oyuncu vardır
             * Her oyuncunun bir zarı vardır
             * Oyuncular zar atar
             * Zarlar karşılaştırılır
             * Büyük atan kazanır
             * 
             * Nesneler:
             * -Oyun
             * -Oyuncu
             * -Zar
             */
        }

        Oyun zarOyunu = new Oyun();

        private void buttonAd1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu1Ad.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1.Text = zarOyunu.BirinciOyuncu.Ad;
        }

        private void buttonAd2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu = new Oyuncu(textBoxOyuncu2Ad.Text);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu2.Text = zarOyunu.IkinciOyuncu.Ad;
        }

        private void buttonOyuncu1_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            buttonOyuncu2.Enabled = true;
        }

        private void buttonOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();

            Oyuncu kazanan = zarOyunu.Karsilastir();
            if (kazanan != null)
            {
                labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı.";
            }
            else
            {
                labelKazanan.Text = "Berabere!!!";
            }

            if (zarOyunu.BirinciOyuncu.Bakiye == 0 || zarOyunu.BirinciOyuncu.Bakiye < 0)
            {
                DialogResult sonuc = MessageBox.Show($"Oyun bitmiştir. Kazanan: {zarOyunu.IkinciOyuncu.Ad}!", "Tebrikler", MessageBoxButtons.OK);
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (zarOyunu.IkinciOyuncu.Bakiye == 0 || zarOyunu.IkinciOyuncu.Bakiye < 0)
            {
                DialogResult sonuc = MessageBox.Show($"Oyun bitmiştir. Kazanan: {zarOyunu.BirinciOyuncu.Ad}!");
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            Bakiye1.Text = zarOyunu.BirinciOyuncu.Bakiye.ToString();
            textBoxOyuncu1Bahis.Text = " ";
            Bahis1.Text = "0";
            Bakiye2.Text = zarOyunu.IkinciOyuncu.Bakiye.ToString();
            textBoxOyuncu2Bahis.Text = " ";
            Bahis2.Text = "0";
        }

        private void buttonOyuncu1BahisGir_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(textBoxOyuncu1Bahis.Text);
            if (miktar > zarOyunu.BirinciOyuncu.Bakiye)
            {
                MessageBox.Show("Bu bahis için yeterli bakiyeniz yok.");
            }
            else
            {
                zarOyunu.IlkOyuncuBahisGir(miktar);
                Bakiye1.Text = zarOyunu.BirinciOyuncu.Bakiye.ToString();
                Bahis1.Text = zarOyunu.BirinciOyuncu.Bahis.ToString();
            }
        }

        private void buttonOyuncu2BahisGir_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(textBoxOyuncu2Bahis.Text);
            if (miktar > zarOyunu.IkinciOyuncu.Bakiye)
            {
                MessageBox.Show("Bu bahis için yeterli bakiyeniz yok.");
            }
            else
            {
                zarOyunu.IkinciOyuncuBahisGir(miktar);
                Bakiye2.Text = zarOyunu.IkinciOyuncu.Bakiye.ToString();
                Bahis2.Text = zarOyunu.IkinciOyuncu.Bahis.ToString();
            }
        }
    }
}

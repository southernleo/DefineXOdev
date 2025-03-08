namespace WinFormsapp
{
    using System;
    using System.Windows.Forms;
    using DefinexAttributeOrnek; // Class Library 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n girdi�i bilgileri al
            Ogrenci ogrenci = new Ogrenci
            {
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Bolum = txtBolum.Text
            };

            // Do�rulama i�lemi
            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                lblSonuc.Text = "��renci bilgileri do�rulamadan ge�emedi!";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblSonuc.Text = "Form ba�ar�l�!";
                lblSonuc.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}

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
            // Kullanýcýnýn girdiði bilgileri al
            Ogrenci ogrenci = new Ogrenci
            {
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Bolum = txtBolum.Text
            };

            // Doðrulama iþlemi
            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                lblSonuc.Text = "Öðrenci bilgileri doðrulamadan geçemedi!";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblSonuc.Text = "Form baþarýlý!";
                lblSonuc.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}

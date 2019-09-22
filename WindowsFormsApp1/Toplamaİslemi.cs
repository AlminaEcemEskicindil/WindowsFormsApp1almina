using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormToplama : Form
    {
        public FormToplama()
        {
            InitializeComponent();
        }
        private void LogYaz(string mesaj)
        {
            lvlog.Items.Add(mesaj);
        }
        void EkranHazirla()
        {
            txtBirinciSayi.Text = "0";
            txtİkinciSayi.Text = "0";
            txtBirinciSayi.Focus();
        }
        int Topla(int sayi1, int sayi2)
        {

            return (sayi1 + sayi2);
        }
        Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(txtBirinciSayi.Text);
                Convert.ToInt32(txtİkinciSayi.Text);
            }
            catch (Exception)
            {
                return false;
            }
            {
                return true;
            }
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
           int BirinciSayi, İkinciSayi, Toplam;

            if (Dogrula())
            {
                BirinciSayi = Convert.ToInt32(txtBirinciSayi.Text);
                İkinciSayi = Convert.ToInt32(txtİkinciSayi.Text);

                Toplam = Topla(BirinciSayi , İkinciSayi);

                MessageBox.Show("Toplam: " + Toplam.ToString());
                EkranHazirla();
                //todo log yaz
                LogYaz("Toplama işlemi başarılı. Birinci Sayı: " + BirinciSayi + ", İkinci sayı");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
                //todo log yaz
                LogYaz("Toplama işlemi başarılı. Birinci Sayı: " + txtBirinciSayi.Text + ", İkinci sayı");
            }

        }

        private void FormToplama_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void FormToplama_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (
                    char.IsLetter(e.KeyChar) ||
                    char.IsSymbol(e.KeyChar) ||
                    char.IsWhiteSpace(e.KeyChar) ||
                    char.IsPunctuation(e.KeyChar)
                    )
                    e.Handled = true;

        }

        private void txtİkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        

        }
    }
    


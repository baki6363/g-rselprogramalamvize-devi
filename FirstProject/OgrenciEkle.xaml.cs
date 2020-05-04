using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FirstProject
{
    /// <summary>
    /// Edit.xaml etkileşim mantığı
    /// </summary>
    public partial class Edit : Window
    {
        List<Bilgiler> bilgiler = new List<Bilgiler>();
        public Edit()
        {
            InitializeComponent();
            lblMesaj.Visibility = Visibility.Hidden;


        }



        int counter = 0;
        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("İsim alanı boş geçilemez…");
                lblMesaj.Visibility = Visibility.Visible;
                lblMesaj.Content = "İsim Alanı boş bırakılamaz";

            }

            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyisim alanı boş geçilemez…");
                lblMesaj.Visibility = Visibility.Visible;
                lblMesaj.Content = "Soyad Alanı boş bırakılamaz";
            }

            else if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Cinsiyet alanı boş geçilemez…");
                lblMesaj.Visibility = Visibility.Visible;
                lblMesaj.Content = "Cinsiyet Alanı boş bırakılamaz";
            }

            else if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Öğrenci No alanı boş geçilemez…");
                lblMesaj.Visibility = Visibility.Visible;
                lblMesaj.Content = "Ogrenci No Alanı boş bırakılamaz";
            }

            else if (cmbBolum.Text == "")
            {
                MessageBox.Show("Bölüm bilgisi boş geçilemez…");
                lblMesaj.Visibility = Visibility.Visible;
                lblMesaj.Content = "Bölüm Alanı boş bırakılamaz";
            }
            
            else
            {

                
                Bilgiler kullanici = new Bilgiler();
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Cinsiyet = cmbCinsiyet.Text;
                kullanici.OgrenciNo = txtOgrenciNo.Text;
                kullanici.Bolum = cmbBolum.Text;
                bilgiler.Add(kullanici);
                tablo2.Items.Add(kullanici);
                cmbIndex.Items.Add(kullanici.OgrenciNo);
                lblMesaj.Visibility = Visibility.Hidden;
            }

        }

        private void cmbIndex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = cmbIndex.SelectedIndex;
            MessageBox.Show("Ad : "+bilgiler[index].Ad 
                + "\tSoyad : " + bilgiler[index].Soyad 
                + "\tCinsiyet : " + bilgiler[index].Cinsiyet 
                + "\tOgrenciNo : " + bilgiler[index].OgrenciNo 
                + "\tBolum : " + bilgiler[index].Bolum);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
            
        }
    }
}
    

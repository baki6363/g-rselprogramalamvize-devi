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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstProject
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    /// 
    public class Bilgiler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string OgrenciNo { get; set; }
        public string Bolum { get; set; }

    }
    public partial class MainWindow : Window
	{
		List<Bilgiler> ogrenci_listesi;
		public MainWindow()
		{
			InitializeComponent();
			ogrenci_listesi = new List<Bilgiler>()
			{
				new Bilgiler() {Ad="ABDULBAKİ",Soyad="ÇELİK",Cinsiyet="Erkek",OgrenciNo="181130074",Bolum="Bilgisayar Programcılığı" }

			};
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			tablo.ItemsSource = ogrenci_listesi;
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			Edit edit1 = new Edit();
			edit1.Show();
			this.Hide();
		}
	}

	
}

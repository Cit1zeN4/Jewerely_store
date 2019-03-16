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

namespace Juwerely_store.Views
{
    /// <summary>
    /// Логика взаимодействия для WareInfoView.xaml
    /// </summary>
    public partial class WareInfoView : Window
    {
        public WareInfoView()
        {
            InitializeComponent();
        }

        public WareInfoView(string name, string about, string image, double price)
        {
            InitializeComponent();
            WareName.Text = name;
            WareAbout.Text = about;
            WareImage.Source = new BitmapImage(new Uri(image, UriKind.Relative));
            WarePrice.Text = price.ToString() + " BYN";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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

namespace Juwerely_store.Views
{
    /// <summary>
    /// Логика взаимодействия для VacansiesView.xaml
    /// </summary>
    public partial class VacansiesView : UserControl
    {
        public VacansiesView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AcceptJogViewxaml accept = new AcceptJogViewxaml();
            accept.Show();
        }

        private void Vac_Click(object sender, RoutedEventArgs e)
        {
            AcceptJogViewxaml accept = new AcceptJogViewxaml();
            accept.Show();

        }

        private void Vacs_Click(object sender, RoutedEventArgs e)
        {
            AcceptJogViewxaml accept = new AcceptJogViewxaml();
            accept.Show();
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            AcceptJogViewxaml accept = new AcceptJogViewxaml();
            accept.Show();
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            AcceptJogViewxaml accept = new AcceptJogViewxaml();
            accept.Show();
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            AcceptJogViewxaml accept = new AcceptJogViewxaml();
            accept.Show();
        }
    }
}

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
    /// Логика взаимодействия для BuyView.xaml
    /// </summary>
    public partial class BuyView : Window
    {
        public BuyView()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if (nume.Text != String.Empty && Soname.Text != String.Empty && FatherName.Text != String.Empty && Exp.Text != String.Empty && Cont.Text != String.Empty && Wanted.Text != String.Empty && cmb.SelectedItem != null && cmb2.SelectedItem != null)
            {
                MessageBox.Show("Ваши данные приняты и находятся в обработке, наш менеджер свяжется с вами");
            }
            else
            {
                MessageBox.Show("Не все поля заполенны");

            }
        }

        private void ButtonOpenWindow_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

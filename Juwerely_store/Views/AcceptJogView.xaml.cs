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
using Microsoft.Win32;

namespace Juwerely_store
{
    /// <summary>
    /// Логика взаимодействия для AcceptJogViewxaml.xaml
    /// </summary>
    public partial class AcceptJogViewxaml : Window
    {
        public AcceptJogViewxaml()
        {
            InitializeComponent();
        }
        private void Download_Click(object sender, RoutedEventArgs e)
        {
            string path = GetPath();
            Image.Source = new BitmapImage(new Uri(path));

        }
        public string GetPath()
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }
            return null;
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if (nume.Text != String.Empty && Soname.Text != String.Empty && FatherName.Text != String.Empty && Exp.Text != String.Empty && AboutYour.Text != String.Empty && Cont.Text != String.Empty && Wanted.Text != String.Empty && Image != null && Cmb.SelectedItem != null)
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

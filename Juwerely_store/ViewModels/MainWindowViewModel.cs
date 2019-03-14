using Juwerely_store.Helpers;
using Juwerely_store.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Juwerely_store.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Fields

        UserControl currentView = new MainWindowView();

        #endregion

        #region Properties

        public UserControl CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Command

        #region Command Fields

        BaseCommand changeCurrentViewCmd;

        #endregion

        #region Command Properties

        public BaseCommand ChangeCurrentViewCommand
        {
            get => changeCurrentViewCmd ?? (changeCurrentViewCmd = new BaseCommand(obj => ChangeCurrentView((int)obj)));
        }

        #endregion

        #region Command Methods

        private void ChangeCurrentView(int i)
        {
            switch (i)
            {
                case 1:
                    CurrentView = new MainWindowView();
                    break;
                case 3:
                    CurrentView = new BrendView();
                    break;
                case 4:
                    CurrentView = new WorkerView();
                    break;
                case 5:
                    CurrentView = new ContactView();
                    break;
                case 6:
                    CurrentView = new chainofstoresView();
                    break;
                case 7:
                    CurrentView = new VacansiesView();
                    break;
                default:
                    MessageBox.Show("Ошибка открытия view");
                    break;
            }
        }

        #endregion

        #endregion

    }
}
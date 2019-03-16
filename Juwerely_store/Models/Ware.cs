using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Juwerely_store.Models
{
    public class Ware : INotifyPropertyChanged
    {
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, e);
        }

        #endregion

        #region Fields

        string name;
        string about;
        string imageSource;
        Category wareCatergory;
        Material wareMaterial;
        double price;

        #endregion

        #region Properties

        public enum Category
        {
            All,
            Ring,
            Earring,
            Chainlet,
            Studs,
            Pendant
        }

        public enum Material
        {
            All,
            Gold,
            Silver
        }

        public int WareId { get; set; }

        public string WareName
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string WareAbout
        {
            get => about;
            set
            {
                about = value;
                OnPropertyChanged();
            }
        }

        public string ImageSource
        {
            get => imageSource;
            set
            {
                imageSource = value;
                OnPropertyChanged();
            }
        }

        public Category WareCategory
        {
            get => wareCatergory;
            set
            {
                wareCatergory = value;
                OnPropertyChanged();
            }
        }

        public Material WareMaterial
        {
            get => wareMaterial;
            set
            {
                wareMaterial = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}

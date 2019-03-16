using Juwerely_store.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Juwerely_store.ViewModels
{
    public class WareCategory : INotifyPropertyChanged
    {
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Constructors

        public WareCategory()
        {

        }

        public WareCategory(Ware.Category category, string name)
        {
            this.name = name;
            this.category = category;
        }

        #endregion

        #region Fields

        string name;
        Ware.Category category;

        #endregion

        #region Properties

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public Ware.Category Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }

    public class WareMaterial : INotifyPropertyChanged
    {
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Constructors

        public WareMaterial()
        {

        }

        public WareMaterial(Ware.Material material, string name)
        {
            this.name = name;
            this.material = material;
        }

        #endregion

        #region Fields

        string name;
        Ware.Material material;

        #endregion

        #region Properties

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public Ware.Material Material
        {
            get => material;
            set
            {
                material = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }

    public class WareViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Fields

        WareCategory selectedCategory;
        WareMaterial selectedMaterial;

        #endregion

        #region Properties

        public ObservableCollection<WareCategory> Categories { get; set; } = new ObservableCollection<WareCategory>
        {
            new WareCategory {Category = Ware.Category.All, Name = "Все"},
            new WareCategory {Category = Ware.Category.Ring, Name = "Кольца"},
            new WareCategory {Category = Ware.Category.Earring, Name = "Серьги"},
            new WareCategory {Category = Ware.Category.Chainlet, Name = "Цепочка"},
            new WareCategory {Category = Ware.Category.Studs, Name = "Гвоздики"},
            new WareCategory {Category = Ware.Category.Pendant, Name = "Кулон"},
        };

        public ObservableCollection<WareMaterial> Materials { get; set; } = new ObservableCollection<WareMaterial>
        {
            new WareMaterial {Material = Ware.Material.All, Name = "Все"},
            new WareMaterial {Material = Ware.Material.Gold, Name = "Золото"},
            new WareMaterial {Material = Ware.Material.Silver, Name = "Серебро"}
        };

        public WareCategory SelectedCategory
        {
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                OnPropertyChanged();
            }
        }

        public WareMaterial SelectedMaterial
        {
            get => selectedMaterial;
            set
            {
                selectedMaterial = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}

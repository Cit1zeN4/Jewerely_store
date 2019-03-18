using Juwerely_store.Helpers;
using Juwerely_store.Models;
using Juwerely_store.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public WareViewModel()
        {
            using (var context = new JewerelyContext())
            {
                Wares = new ObservableCollection<Ware>(context.Wares.ToList());
            }
        }

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
        string searchString = "";
        ObservableCollection<Ware> wares;

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

        public string SearchString
        {
            get => searchString;
            set
            {
                searchString = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Ware> Wares
        {
            get => wares;
            set
            {
                wares = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Command

        #region Command Fields

        BaseCommand searchCmd;
        BaseCommand showInfoCmd;

        #endregion

        #region Command Properties

        public BaseCommand SearchCommand
        {
            get => searchCmd ?? (searchCmd = new BaseCommand(obj => Search()));
        }

        public BaseCommand ShowInfoCommand
        {
            get => showInfoCmd ?? (showInfoCmd = new BaseCommand(obj => ShowInfo((int)obj)));
        }

        #endregion

        #region Command Methods

        private void Search()
        {
            // 000
            if (SelectedCategory.Category == Ware.Category.All
                && SelectedMaterial.Material == Ware.Material.All
                && SearchString == "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares.ToList());
                }
            }
            // 100
            if (SelectedCategory.Category != Ware.Category.All
                && SelectedMaterial.Material == Ware.Material.All
                && SearchString == "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares
                        .Where(o => o.WareCategory == SelectedCategory.Category).ToList());
                }
            }
            //110
            if (SelectedCategory.Category != Ware.Category.All
                && SelectedMaterial.Material != Ware.Material.All
                && SearchString == "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares
                        .Where(o => o.WareCategory == SelectedCategory.Category && o.WareMaterial == SelectedMaterial.Material).ToList());
                }
            }
            //111
            if (SelectedCategory.Category != Ware.Category.All
                && SelectedMaterial.Material != Ware.Material.All
                && SearchString != "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares
                        .Where(o => o.WareCategory == SelectedCategory.Category && o.WareMaterial == SelectedMaterial.Material && o.WareName.Contains(SearchString))
                        .ToList());
                }
            }
            //101
            if (SelectedCategory.Category != Ware.Category.All
                && SelectedMaterial.Material == Ware.Material.All
                && SearchString != "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares
                        .Where(o => o.WareCategory == SelectedCategory.Category && o.WareName.Contains(SearchString)).ToList());
                }
            }
            //011
            if (SelectedCategory.Category == Ware.Category.All
                && SelectedMaterial.Material != Ware.Material.All
                && SearchString != "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares
                        .Where(o => o.WareMaterial == SelectedMaterial.Material && o.WareName.Contains(SearchString)).ToList());
                }
            }
            //001
            if (SelectedCategory.Category == Ware.Category.All
                && SelectedMaterial.Material == Ware.Material.All
                && SearchString != "")
            {
                using (var context = new JewerelyContext())
                {
                    Wares = new ObservableCollection<Ware>(context.Wares
                        .Where(o => o.WareName.Contains(SearchString)).ToList());
                }
            }
        }
        private void ShowInfo(int id)
        {
            Ware ware;
            using (var context = new JewerelyContext())
            {
                ware = context.Wares.Where(o => o.WareId == id).FirstOrDefault();
            }
            WareInfoView info = new WareInfoView(ware.WareName, ware.WareAbout, ware.ImageSource, ware.Price);
            info.ShowDialog();
        }

        #endregion

        #endregion
    }
}
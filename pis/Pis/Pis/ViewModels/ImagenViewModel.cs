using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pis.ViewModels
{
    public class ImagenViewModel : BaseViewModel
    {
        #region Atributes
        private ObservableCollection<ImagenesViewModel> listai;
        private bool isRefreshing;
        private bool isEnabled;
        #endregion

        #region Properties
        public ObservableCollection<ImagenesViewModel> Listai
        {
            get { return this.listai; }
            set { SetValue(ref this.listai, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public ImagenViewModel()
        {
            this.IsEnabled = true;
            this.LoadListai();
        }
        #endregion

        #region Methods
        private void LoadListai()
        {
            this.IsRefreshing = true;
            this.IsEnabled = true;
            this.Listai = new ObservableCollection<ImagenesViewModel>();
            if (varGlobal.img == "sach")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Tobillo sólido con talón blando, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles",
                    Title = "Pie SACH"
                });
            }

            if (varGlobal.img == "articulado")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Pie articulado uniaxial en aluminio o titanio",
                    Title = "Pie articulado"
                });
            }





            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadListai);
            }
        }
        #endregion
    }
}

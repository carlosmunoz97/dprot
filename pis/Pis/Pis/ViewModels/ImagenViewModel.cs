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
        #endregion

        #region Constructors
        public ImagenViewModel()
        {
            this.LoadListai();
        }
        #endregion

        #region Methods
        private void LoadListai()
        {
            this.IsRefreshing = true;
            this.Listai = new ObservableCollection<ImagenesViewModel>();
            if (varGlobal.img == )
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "tfk3unoPage",
                    Title = "Primera opción"
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

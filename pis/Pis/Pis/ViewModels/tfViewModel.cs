

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    public class tfViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<ListaItemViewModel> listatf;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ListaItemViewModel> Listatf
        {
            get { return this.listatf; }
            set { SetValue(ref this.listatf, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public tfViewModel()
        {
            this.LoadListatf();
        }
        #endregion

        #region Methods
        private void LoadListatf()
        {
            this.IsRefreshing = true;
            this.Listatf = new ObservableCollection<ListaItemViewModel>();

            this.Listatf.Add(new ListaItemViewModel
            {
                Icon = "uno.png",
                PageName = "tfk1unoPage",
                Title = "Primera opción"
            });

            this.Listatf.Add(new ListaItemViewModel
            {
                Icon = "dos.png",
                PageName = "tfk1dosPage",
                Title = "Segunda opción"
            });
            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadListatf);
            }
        }
        #endregion
    }
}


using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Pis.ViewModels
{
    public class ttViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<ListaItemViewModel> listatt;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ListaItemViewModel> Listatt
        {
            get { return this.listatt; }
            set { SetValue(ref this.listatt, value);}
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public ttViewModel()
        {
            this.LoadListatt();
        }
        #endregion

        #region Methods
        private void LoadListatt()
        {
            this.IsRefreshing = true;
            this.Listatt = new ObservableCollection<ListaItemViewModel>();

            this.Listatt.Add(new ListaItemViewModel
            {
                Icon = "uno.png",
                PageName = "ttk1unoPage",
                Title = "Primera opción"
            });

            this.Listatt.Add(new ListaItemViewModel
            {
                Icon = "dos.png",
                PageName = "ttk1dosPage",
                Title = "Segunda opción"
            });

            this.Listatt.Add(new ListaItemViewModel
            {
                Icon = "tres.png",
                PageName = "ttk1tresPage",
                Title = "Tercera opción"
            });

            this.Listatt.Add(new ListaItemViewModel
            {
                Icon = "cuatro.png",
                PageName = "ttk1cuatroPage",
                Title = "Cuarta opción"
            });
            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadListatt);
            }
        }        
        #endregion
    }
}

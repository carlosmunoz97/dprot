using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pis.ViewModels
{
    public class tfdosViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<ListaItemViewModel> listatf2;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ListaItemViewModel> Listatf2
        {
            get { return this.listatf2; }
            set { SetValue(ref this.listatf2, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public tfdosViewModel()
        {
            this.LoadListatf1();
        }
        #endregion

        #region Methods
        private void LoadListatf1()
        {
            this.IsRefreshing = true;
            this.Listatf2 = new ObservableCollection<ListaItemViewModel>();

            this.Listatf2.Add(new ListaItemViewModel
            {
                Icon = "uno.png",
                PageName = "tfk3unoPage",
                Title = "Primera opción"
            });

            this.Listatf2.Add(new ListaItemViewModel
            {
                Icon = "dos.png",
                PageName = "tfk3dosPage",
                Title = "Segunda opción"
            });

            this.Listatf2.Add(new ListaItemViewModel
            {
                Icon = "tres.png",
                PageName = "tfk3tresPage",
                Title = "Tercera opción"
            });

            this.Listatf2.Add(new ListaItemViewModel
            {
                Icon = "cuatro.png",
                PageName = "tfk3cuatroPage",
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
                return new RelayCommand(LoadListatf1);
            }
        }
        #endregion
    }
}

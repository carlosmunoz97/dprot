using GalaSoft.MvvmLight.Command;
using Pis.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pis.ViewModels
{
    public class drk4dosViewModel : BaseViewModel
    {
        #region Attributes
        private bool isEnabled;
        #endregion

        #region Properties
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands
        public ICommand Alerta1Command
        {
            get
            {
                return new RelayCommand(alerta1);
            }
        }
        public ICommand Alerta2Command
        {
            get
            {
                return new RelayCommand(alerta2);
            }
        }
        public ICommand Alerta3Command
        {
            get
            {
                return new RelayCommand(alerta3);
            }
        }
        public ICommand Alerta4Command
        {
            get
            {
                return new RelayCommand(alerta4);
            }
        }
        public ICommand Alerta5Command
        {
            get
            {
                return new RelayCommand(alerta5);
            }
        }
        public ICommand Alerta6Command
        {
            get
            {
                return new RelayCommand(alerta6);
            }
        }

        private async void alerta1()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "fibradecarbono";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Fibra de carbono",
            //   "Diseño de contención isquiática (ovoidea)",
            //    "aceptar");
            //return;
        }
        private async void alerta2()
        {
            this.isEnabled = true;
            //noshta 
            await Application.Current.MainPage.DisplayAlert(
                "Válvula de vacío con anillo",
                "Expulsa el aire residual automáticamente, evita el hecho de que se haga manualmente",
                "aceptar");
            return;
        }
        private async void alerta3()
        {
            this.isEnabled = true;
            //noshta
            await Application.Current.MainPage.DisplayAlert(
                 "Copolímero o silicona",
                "Interface hecha de copolímero o silicona",
                "aceptar");
            return;
        }
        private async void alerta4()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "monocentrica";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Monocéntrica con control de fluidos",
            //    "Monocéntrica con control de fluidos y sistema rotatorio",
            //    "aceptar");
            //return;
        }
        private async void alerta5()
        {
            this.isEnabled = true;
            //noshta 
            await Application.Current.MainPage.DisplayAlert(
                "Titanio o acero ",
                "Se usan componentes intercambiables estandarizados hechos de acero o titanio",
                "aceptar");
            return;
        }
        private async void alerta6()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "piecarbono";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie articulado",
            //    "Pie articulado de respuesta dinámica alta y resistencia moderada  (pie en carbono de alta resistencia y alto impacto para un K4)",
            //    "aceptar");
        }
        #endregion

        #region Constructors
        public drk4dosViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

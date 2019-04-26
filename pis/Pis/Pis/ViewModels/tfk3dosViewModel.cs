using GalaSoft.MvvmLight.Command;
using Pis.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pis.ViewModels
{
    public class tfk3dosViewModel : BaseViewModel
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
        public ICommand Alerta7Command
        {
            get
            {
                return new RelayCommand(alerta7);
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
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "pin";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pin y lanzadera",
            //    "Se usa un liner con pin asegurado por una lanzadera en su parte inferior para mayor sujeción",
            //    "aceptar");
            //return;
        }
        private async void alerta3()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "silicona";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Silicona",
            //    "Interface hecha de silicona",
            //    "aceptar");
            //return;
        }
        private async void alerta4()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "policentrica";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //   "Policéntrica con control de fluidos",
            //    "Rodilla neumática o hidráulica con control de fluidos",
            //    "aceptar");
            //return;
        }
        private async void alerta5()
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
        private async void alerta6()
        {
            this.isEnabled = true;
            //no etsiste
            await Application.Current.MainPage.DisplayAlert(
                "Titanio o acero ",
                "Se usan componentes intercambiables estandarizados hechos de acero o titanio",
                "aceptar");
            return;
        }
        private async void alerta7()
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
        public tfk3dosViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

﻿using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Pis.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class tfk1dosViewModel : BaseViewModel
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
            //noshta
            await Application.Current.MainPage.DisplayAlert(
                "Polipropileno",
                "Encaje que proporciona una adaptación íntima sobre la superficie del muñón, para mejorar los puntos de presión",
                "aceptar");
            return;
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
            varGlobal.img = "monocentricafreno";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Monocéntrica de freno a la carga",
            //    "Hecha de aluminio o titanio",
            //    "aceptar");
            //return;
        }
        private async void alerta5()
        {
            this.isEnabled = true;
            //noshta
            await Application.Current.MainPage.DisplayAlert(
                "Aluminio o titanio",
                "Se usan componentes intercambiables estandarizados hechos de aluminio o titanio",
                "aceptar");
            return;
        }
        private async void alerta6()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "sach";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());
            //await Application.Current.MainPage.DisplayAlert(
            // "Pie SACH",
            //"Tobillo sólido con talón blando, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles",
            //"aceptar");
            //return;
        }
        private async void alerta7()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "articulado";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie articulado",
            //    "Pie articulado uniaxial en aluminio o titanio",
            //    "aceptar");
            //return;
        }
        #endregion

        #region Constructors
        public tfk1dosViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

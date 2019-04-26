using System;
using System.Collections.Generic;
using System.Text;

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Pis.Views;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class ttk1cuatroViewModel : BaseViewModel
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
            //no está
            await Application.Current.MainPage.DisplayAlert(
                "Contacto total",
                "Toda el área del muñón en contacto con las paredes (su extremo distal puede ser blando o rígido)",
                "aceptar");
            return;
        }
        private async void alerta2()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "vacio";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Válvula de vacío",
            //    "Se usa en pacientes con buena musculatura y fuerza, ofrece mayor libertad de movimiento y comodidad (se adapta a la velocidad de la marcha)",
            //    "aceptar");
            //return;
        }
        private async void alerta3()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "modular";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Exoesquelético modular",
            //    "Se usan componentes intercambiables estandarizados hechos de aluminio o titanio",
            //    "aceptar");
            //return;
        }
        private async void alerta4()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "poliuretano";
            
            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Poliuretano",
            //    "Interface hecha de poliuretano",
            //    "aceptar");
            //return;
        }
        private async void alerta5()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "sach";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie SACH",
            //    "Tobillo sólido con talón blando, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles, para el caso de un K2 se usa un SACH en carbono",
            //    "aceptar");
            //return;
        }
        private async void alerta6()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "articulado";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie articulado",
            //    "Pie articulado uniaxial en aluminio o titanio, para el caso de un K2 se usa un pie de respuesta dinámica media",
            //    "aceptar");
            //return;
        }
        #endregion

        #region Constructors
        public ttk1cuatroViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

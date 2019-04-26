using System;
using System.Collections.Generic;
using System.Text;

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class pieunoViewModel : BaseViewModel
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

        private async void alerta1()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "sach";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie SACH, rigido o flexible",
            //    "Tobillo sólido con talón blando en carbono, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles",
            //    "aceptar");
            //return;
        }
        private async void alerta2()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "articulado";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie articulado",
            //    "Pie articulado uniaxial de respuesta dinámica media (en carbono)",
            //    "aceptar");
            //return;
        }
        #endregion

        #region Constructors
        public pieunoViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

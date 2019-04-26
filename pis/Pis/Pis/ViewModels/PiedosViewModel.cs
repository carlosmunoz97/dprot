using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;
using Pis.Views;


namespace Pis.ViewModels
{
    public class PiedosViewModel : BaseViewModel
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

        private async void alerta1()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.img = "multiaxial";

            MainViewModel.GetInstance().image = new ImagenViewModel();
            await App.Navigator.PushAsync(new ImagenPage());

            //await Application.Current.MainPage.DisplayAlert(
            //    "Pie articulado multiaxial de respuesta dinámica",
            //    "Pie articulado multiaxial de respuesta dinámica alta (en carbono, con resistencia definida por el técnico)",
            //    "aceptar");
            //return;
        }
        
        #endregion

        #region Constructors
        public PiedosViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

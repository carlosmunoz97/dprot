using System;
using System.Collections.Generic;
using System.Text;

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    public class ttk1unoViewModel : BaseViewModel
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

        private async void alerta1()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Encaje de apoyo en el tendón rotuliano (PTB)",
                "Encaje hecho de plástico laminado termoformado que proporciona una adaptación íntima sobre la superficie del muñón, incluyendo el extremo distal.",
                "aceptar");
            return;
        }
        private async void alerta2()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Correa suprancondilea",
                "Sujeta al encaje en las áreas posteromedial y posterolateral, envuelve el muslo por encima de los epicóndilos y la rótula",
                "aceptar");
            return;
        }
        private async void alerta3()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Exoesquelético modular",
                "Se usan componentes intercambiables estandarizados hechos de aluminio o titanio",
                "aceptar");
            return;
        }
        private async void alerta4()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Pie SACH",
                "Tobillo sólido con talón blando, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles, para el caso de un K2 se usa un SACH en carbono",
                "aceptar");
            return;
        }
        private async void alerta5()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Pie articulado",
                "Pie articulado uniaxial en aluminio o titanio, para el caso de un K2 se usa un pie de respuesta dinámica media",
                "aceptar");
            return;
        }
        #endregion

        #region Constructors
        public ttk1unoViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}


namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;
    public class pieViewModel : BaseViewModel
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

            await Application.Current.MainPage.DisplayAlert(
                "Pie SACH",
                "Tobillo sólido con talón blando, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles",
                "aceptar");
            return;
        }
        private async void alerta2()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Pie articulado",
                "Pie articulado uniaxial en aluminio o titanio",
                "aceptar");
            return;
        }
        #endregion

        #region Constructors
        public pieViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}
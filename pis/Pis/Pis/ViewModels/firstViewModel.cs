
namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class firstViewModel : BaseViewModel
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
        public ICommand IniciarCommand
        {
            get
            {
                return new RelayCommand(iniciar);
            }
        }



        private async void iniciar()
        {
            this.isEnabled = true;

            MainViewModel.GetInstance().fracturas = new fracturasViewModel();
            await App.Navigator.PushAsync( new fracturaspage());
            
        }
        #endregion

        #region Constructors
        public firstViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

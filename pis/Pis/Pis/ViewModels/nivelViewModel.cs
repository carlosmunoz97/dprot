
namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;
    public class nivelViewModel : BaseViewModel
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

        #region Command
        public ICommand UnoCommand
        {
            get
            {
                return new RelayCommand(uno);
            }
        }
        private async void uno()
        {
            
            this.isEnabled = true;
            

            if (varGlobal.ecg == "pie")
            {
                MainViewModel.GetInstance().pie = new pieViewModel();
                await App.Navigator.PushAsync(new piepage());
                //await Application.Current.MainPage.Navigation.PushAsync(new piepage());
            } 
            if (varGlobal.ecg == "tt")
            {
                MainViewModel.GetInstance().tt = new ttViewModel();
                await App.Navigator.PushAsync(new ttpage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttpage());
            }

            if (varGlobal.ecg == "dr")
            {
                await Application.Current.MainPage.DisplayAlert(
                "Desarticulado de rodilla K1",
                "No hay pacientes desarticulados de rodilla con nivel de actividad k1",
                "aceptar");
                return;
            }

            if (varGlobal.ecg == "tf")
            {
                MainViewModel.GetInstance().tf = new tfViewModel();
                await App.Navigator.PushAsync(new tfpage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfpage());
            }
        }

        public ICommand DosCommand
        {
            get
            {
                return new RelayCommand(dos);
            }
        }
        private async void dos()
        {
            
            this.isEnabled = true;


            if (varGlobal.ecg == "pie")
            {
                MainViewModel.GetInstance().pieone = new pieunoViewModel();
                await App.Navigator.PushAsync(new pieuno());
                //await Application.Current.MainPage.Navigation.PushAsync(new pieuno());
            }
            if (varGlobal.ecg == "tt")
            {
                MainViewModel.GetInstance().tt = new ttViewModel();
                await App.Navigator.PushAsync(new ttpage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttpage());
            }

            if (varGlobal.ecg == "dr")
            {
                await Application.Current.MainPage.DisplayAlert(
                "Desarticulado de rodilla K2",
                "No hay pacientes desarticulados de rodilla con nivel de actividad K2",
                "aceptar");
                return;
            }

            if (varGlobal.ecg == "tf")
            {
                MainViewModel.GetInstance().tfone = new tfunoViewModel();
                await App.Navigator.PushAsync(new tfuno());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfuno());
            }
        }
        public ICommand TresCommand
        {
            get
            {
                return new RelayCommand(tres);
            }
        }
        private async void tres()
        {

            this.isEnabled = true;


            if (varGlobal.ecg == "pie")
            {
                MainViewModel.GetInstance().piedos = new PiedosViewModel();
                await App.Navigator.PushAsync(new piedos());
                //await Application.Current.MainPage.Navigation.PushAsync(new piedos());
            }
            if (varGlobal.ecg == "tt")
            {
                MainViewModel.GetInstance().ttone = new ttunoViewModel();
                await App.Navigator.PushAsync(new ttuno());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttuno());
            }
            if (varGlobal.ecg == "dr")
            {
                MainViewModel.GetInstance().dr = new drViewModel();
                await App.Navigator.PushAsync(new drpage());
                //await Application.Current.MainPage.Navigation.PushAsync(new drpage());
            }
            if (varGlobal.ecg == "tf")
            {
                MainViewModel.GetInstance().tftwo = new tfdosViewModel();
                await App.Navigator.PushAsync(new tfdosPage());
                //wait Application.Current.MainPage.Navigation.PushAsync(new tfdosPage());
            }
        }
        public ICommand CuatroCommand
        {
            get
            {
                return new RelayCommand(cuatro);
            }
        }
        private async void cuatro()
        {

            this.isEnabled = true;


            if (varGlobal.ecg == "pie")
            {
                MainViewModel.GetInstance().piedos = new PiedosViewModel();
                await App.Navigator.PushAsync(new piedos());
                //await Application.Current.MainPage.Navigation.PushAsync(new piedos());
            }
            if (varGlobal.ecg == "tt")
            {
                MainViewModel.GetInstance().tttwo = new ttdos();
                await App.Navigator.PushAsync(new ttdosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttdosPage());
            }
            if (varGlobal.ecg == "dr")
            {
                MainViewModel.GetInstance().drone = new drunoViewModel();
                await App.Navigator.PushAsync(new druno());
                //await Application.Current.MainPage.Navigation.PushAsync(new druno());
            }
            if (varGlobal.ecg == "tf")
            {
                MainViewModel.GetInstance().tftwo = new tfdosViewModel();
                await App.Navigator.PushAsync(new tfdosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfdosPage());
            }
        }
        #endregion

        #region Constructors
        public nivelViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

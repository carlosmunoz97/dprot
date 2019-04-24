

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;
    public class fracturasViewModel : BaseViewModel
    {
        #region Attributes
        private bool isEnabled;
        
        public string a;
        #endregion

        #region Properties
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands
        public ICommand PieCommand
        {
            get
            {
                return new RelayCommand(pie);
            }
        }
        public async void pie()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.ecg = "pie";
            
            MainViewModel.GetInstance().nivel = new nivelViewModel();
            await App.Navigator.PushAsync(new nivelpage());
            //await Application.Current.MainPage.Navigation.PushAsync(new nivelpage());

        }

        public ICommand TranstibialCommand
        {
            get
            {
                return new RelayCommand(transtibial);
            }
        }
        public async void transtibial()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.ecg = "tt";


            MainViewModel.GetInstance().nivel = new nivelViewModel();
            await App.Navigator.PushAsync(new nivelpage());
            //await Application.Current.MainPage.Navigation.PushAsync(new nivelpage());
            
        }

        public ICommand DesarticuladoCommand
        {
            get
            {
                return new RelayCommand(desarticulado);
            }
        }
        public async void desarticulado()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.ecg = "dr";


            MainViewModel.GetInstance().nivel = new nivelViewModel();
            await App.Navigator.PushAsync(new nivelpage());
            //await Application.Current.MainPage.Navigation.PushAsync(new nivelpage());
            
        }

        public ICommand RodillaCommand
        {
            get
            {
                return new RelayCommand(rodilla);
            }
        }
        public async void rodilla()
        {
            this.isEnabled = true;
            varGlobal varGlobal = new varGlobal();
            varGlobal.ecg = "tf";


            MainViewModel.GetInstance().nivel = new nivelViewModel();
            await App.Navigator.PushAsync(new nivelpage());
            //await Application.Current.MainPage.Navigation.PushAsync(new nivelpage());
            
        }
        #endregion

        #region Constructors
        public fracturasViewModel()
        {
            this.IsEnabled = true;
        }

        
        #endregion

        
    }
}

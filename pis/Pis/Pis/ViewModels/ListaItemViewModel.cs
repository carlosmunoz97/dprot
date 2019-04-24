namespace Pis.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Pis.Models;
    using Pis.Views;
    using Xamarin.Forms;
    public class ListaItemViewModel : Lista
    {
        #region Commands
        public ICommand SelectOptionCommand
        {
            get
            {
                return new RelayCommand(SelectOption);
            }
            #endregion
        }

        private async void SelectOption()
        {
            if (PageName == "ttk1unoPage")
            {
                MainViewModel.GetInstance().ttk11 = new ttk1unoViewModel();
                await App.Navigator.PushAsync(new ttk1unoPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttk1unoPage());
            }

            if (PageName == "ttk1dosPage")
            {
                MainViewModel.GetInstance().ttk12 = new ttk1dosViewModel();
                await App.Navigator.PushAsync(new ttk1dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttk1dosPage());
            }

            if (PageName == "ttk1tresPage")
            {
                MainViewModel.GetInstance().ttk13 = new ttk1tresViewModel();
                await App.Navigator.PushAsync(new ttk1tresPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttk1tresPage());
            }

            if (PageName == "ttk1cuatroPage")
            {
                MainViewModel.GetInstance().ttk14 = new ttk1cuatroViewModel();
                await App.Navigator.PushAsync(new ttk1cuatroPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttk1cuatroPage());
            }

            if (PageName == "tfk1unoPage")
            {
                MainViewModel.GetInstance().tfk11 = new tfk1unoViewModel();
                await App.Navigator.PushAsync(new tfk1unoPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk1unoPage());
            }

            if (PageName == "tfk1dosPage")
            {
                MainViewModel.GetInstance().tfk12 = new tfk1dosViewModel();
                await App.Navigator.PushAsync(new tfk1dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk1dosPage());
            }

            if (PageName == "tfk2unoPage")
            {
                MainViewModel.GetInstance().tfk21 = new tfk2unoViewModel();
                await Application.Current.MainPage.Navigation.PushAsync(new tfk2unoPage());
            }

            if (PageName == "tfk2dosPage")
            {
                MainViewModel.GetInstance().tfk22 = new tfk2dosViewModel();
                await App.Navigator.PushAsync(new tfk2dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk2dosPage());
            }

            if (PageName == "tfk3unoPage")
            {
                MainViewModel.GetInstance().tfk31 = new tfk3unoViewModel();
                await App.Navigator.PushAsync(new tfk3unoPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk3unoPage());
            }

            if (PageName == "tfk3dosPage")
            {
                MainViewModel.GetInstance().tfk32 = new tfk3dosViewModel();
                await App.Navigator.PushAsync(new tfk3dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk3dosPage());
            }

            if (PageName == "tfk3tresPage")
            {
                MainViewModel.GetInstance().tfk33 = new tfk3tresViewModel();
                await App.Navigator.PushAsync(new tfk3tresPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk3tresPage());
            }

            if (PageName == "tfk3cuatroPage")
            {
                MainViewModel.GetInstance().tfk34 = new tfk3cuatroViewModel();
                await App.Navigator.PushAsync(new tfk3cuatroPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new tfk3cuatroPage());
            }

            if (PageName == "drk3unoPage")
            {
                MainViewModel.GetInstance().drk31 = new drk3unoViewModel();
                await App.Navigator.PushAsync(new drk3unoPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new drk3unoPage());
            }

            if (PageName == "drk3dosPage")
            {
                MainViewModel.GetInstance().drk32 = new drk3dosViewModel();
                await App.Navigator.PushAsync(new drk3dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new drk3dosPage());
            }

            if (PageName == "drk4unoPage")
            {
                MainViewModel.GetInstance().drk41 = new drk4unoViewModel();
                await App.Navigator.PushAsync(new drk4unoPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new drk4unoPage());
            }

            if (PageName == "drk4dosPage")
            {
                MainViewModel.GetInstance().drk42 = new drk4dosViewModel();
                await App.Navigator.PushAsync(new drk4dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new drk4dosPage());
            }
        }
    }
}
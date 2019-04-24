using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Pis.Models;
using Pis.Views;
using Xamarin.Forms;

namespace Pis.ViewModels
{
    public class Listatt2ViewModel : Lista
    {
        #region Commands
        public ICommand SelectOption2Command
        {
            get
            {
                return new RelayCommand(SelectOption2);
            }
            #endregion
        }

        private async void SelectOption2()
        {
            if (PageName == "ttk2unoPage")
            {
                MainViewModel.GetInstance().ttk21 = new ttk2unoViewModel();
                await App.Navigator.PushAsync(new ttk2unoPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttk2unoPage());
            }

            if (PageName == "ttk2dosPage")
            {
                MainViewModel.GetInstance().ttk22 = new ttk2dosViewModel();
                await App.Navigator.PushAsync(new ttk2dosPage());
                //await Application.Current.MainPage.Navigation.PushAsync(new ttk2dosPage());
            }
        }
    }
}

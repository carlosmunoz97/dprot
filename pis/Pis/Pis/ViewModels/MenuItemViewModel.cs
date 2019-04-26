using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Pis.Views;

namespace Pis.ViewModels
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        #region Commands
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }

        private async void Navigate()
        {
            if (this.PageName == "firstPage")
            {
                MainViewModel.GetInstance().fracturas = new fracturasViewModel();
                await App.Navigator.PushAsync( new fracturaspage());
            }

            

            if (this.PageName == "nosotrosPage")
            {
                MainViewModel.GetInstance().nosotros = new nosotrosViewModel();
                await App.Navigator.PushAsync(new nosotrosPage());
            }
        }
        #endregion
    }
}

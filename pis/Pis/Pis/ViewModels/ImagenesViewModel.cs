using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Pis.Models;

namespace Pis.ViewModels
{
    class ImagenesViewModel : Imagenes
    {
        #region Commands
        public ICommand SelectOptionCommand
        {
            get
            {
                return new RelayCommand(SelectOption);
            }

        }

        private async void SelectOption()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}

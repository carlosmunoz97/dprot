using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Pis.ViewModels
{
    public class drViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<ListaItemViewModel> listadr;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ListaItemViewModel> Listadr
        {
            get { return this.listadr; }
            set { SetValue(ref this.listadr, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public drViewModel()
        {
            this.LoadListadr();
        }
        #endregion

        #region Methods
        private void LoadListadr()
        {
            this.IsRefreshing = true;
            this.Listadr = new ObservableCollection<ListaItemViewModel>();

            this.Listadr.Add(new ListaItemViewModel
            {
                Icon = "uno.png",
                PageName = "drk3unoPage",
                Title = "Primera opción"
            });

            this.Listadr.Add(new ListaItemViewModel
            {
                Icon = "dos.png",
                PageName = "drk3dosPage",
                Title = "Segunda opción"
            });
            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadListadr);
            }
        }
        #endregion
    }
}

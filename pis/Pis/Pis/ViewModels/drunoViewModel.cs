using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Pis.ViewModels
{
    public class drunoViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<ListaItemViewModel> listadr1;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ListaItemViewModel> Listadr1
        {
            get { return this.listadr1; }
            set { SetValue(ref this.listadr1, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public drunoViewModel()
        {
            this.LoadListadr1();
        }
        #endregion

        #region Methods
        private void LoadListadr1()
        {
            this.IsRefreshing = true;
            this.Listadr1 = new ObservableCollection<ListaItemViewModel>();

            this.Listadr1.Add(new ListaItemViewModel
            {
                Icon = "uno.png",
                PageName = "drk4unoPage",
                Title = "Primera opción"
            });

            this.Listadr1.Add(new ListaItemViewModel
            {
                Icon = "dos.png",
                PageName = "drk4dosPage",
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
                return new RelayCommand(LoadListadr1);
            }
        }
        #endregion
    }
}

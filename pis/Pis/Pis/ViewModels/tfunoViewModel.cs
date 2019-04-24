using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Pis.ViewModels
{
    public class tfunoViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<ListaItemViewModel> listatf1;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<ListaItemViewModel> Listatf1
        {
            get { return this.listatf1; }
            set { SetValue(ref this.listatf1, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public tfunoViewModel()
        {
            this.LoadListatf1();
        }
        #endregion

        #region Methods
        private void LoadListatf1()
        {
            this.IsRefreshing = true;
            this.Listatf1 = new ObservableCollection<ListaItemViewModel>();

            this.Listatf1.Add(new ListaItemViewModel
            {
                Icon = "uno.png",
                PageName = "tfk2unoPage",
                Title = "Primera opción"
            });

            this.Listatf1.Add(new ListaItemViewModel
            {
                Icon = "dos.png",
                PageName = "tfk2dosPage",
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
                return new RelayCommand(LoadListatf1);
            }
        }
        #endregion
    }
}

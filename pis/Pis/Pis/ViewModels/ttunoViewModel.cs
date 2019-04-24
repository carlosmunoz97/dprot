using System;
using System.Collections.Generic;
using System.Text;

namespace Pis.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using System.Collections.ObjectModel;

    public class ttunoViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Listatt2ViewModel> listatt2;
        private bool isRefreshing;
        #endregion

        #region Properties
        public ObservableCollection<Listatt2ViewModel> Listatt2
        {
            get { return this.listatt2; }
            set { SetValue(ref this.listatt2, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion

        #region Constructors
        public ttunoViewModel()
        {
            this.LoadListatt2();
        }
        #endregion

        #region Methods
        private void LoadListatt2()
        {
            this.IsRefreshing = true;
            this.Listatt2 = new ObservableCollection<Listatt2ViewModel>();

            this.Listatt2.Add(new Listatt2ViewModel
            {
                Icon = "uno.png",
                PageName = "ttk2unoPage",
                Title = "Primera opción"
            });

            this.Listatt2.Add(new Listatt2ViewModel
            {
                Icon = "dos.png",
                PageName = "ttk2dosPage",
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
                return new RelayCommand(LoadListatt2);
            }
        }


        #endregion
    }
}

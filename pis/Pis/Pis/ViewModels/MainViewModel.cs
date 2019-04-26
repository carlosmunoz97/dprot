

using System;
using System.Collections.ObjectModel;

namespace Pis.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }
        #endregion

        #region ViewModels
        public firstViewModel first
        {
            get;
            set;
        }

        public nosotrosViewModel nosotros
        {
            get;
            set;
        }

        public ImagenViewModel image
        {
            get;
            set;
        }
        

        public fracturasViewModel fracturas
        {
            get;
            set;
        }

        public nivelViewModel nivel
        {
            get;
            set;
        }

        public pieViewModel pie
        {
            get;
            set;
        }

        public pieunoViewModel pieone
        {
            get;
            set;
        }

        public PiedosViewModel piedos
        {
            get;
            set;
        }

        public ttViewModel tt
        {
            get;
            set;
        }

        public ttunoViewModel ttone
        {
            get;
            set;
        }

        public ttdos tttwo
        {
            get;
            set;
        }

        public ttk1unoViewModel ttk11
        {
            get;
            set;
        }

        public ttk1dosViewModel ttk12
        {
            get;
            set;
        }

        public ttk1tresViewModel ttk13
        {
            get;
            set;
        }

        public ttk1cuatroViewModel ttk14
        {
            get;
            set;
        }

        public ttk2unoViewModel ttk21
        {
            get;
            set;
        }

        public ttk2dosViewModel ttk22
        {
            get;
            set;
        }

        public drViewModel dr
        {
            get;
            set;
        }

        public drk3unoViewModel drk31
        {
            get;
            set;
        }

        public drk3dosViewModel drk32
        {
            get;
            set;
        }

        public drk4unoViewModel drk41
        {
            get;
            set;
        }

        public drk4dosViewModel drk42
        {
            get;
            set;
        }

        public drunoViewModel drone
        {
            get;
            set;
        }

        public tfViewModel tf
        {
            get;
            set;
        }

        public tfunoViewModel tfone
        {
            get;
            set;
        }

        public tfk1unoViewModel tfk11
        {
            get;
            set;
        }

        public tfk1dosViewModel tfk12
        {
            get;
            set;
        }

        public tfdosViewModel tftwo
        {
            get;
            set;
        }

        public tfk2unoViewModel tfk21
        {
            get;
            set;
        }

        public tfk2dosViewModel tfk22
        {
            get;
            set;
        }

        public tfk3unoViewModel tfk31
        {
            get;
            set;
        }

        public tfk3dosViewModel tfk32
        {
            get;
            set;
        }

        public tfk3tresViewModel tfk33
        {
            get;
            set;
        }

        public tfk3cuatroViewModel tfk34
        {
            get;
            set;
        }        
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.first = new firstViewModel();
            this.LoadMenu();
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_tibial.png",
                PageName = "firstPage",
                Title = "Prescripción"
            });

            

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_assignment.png",
                PageName = "nosotrosPage",
                Title = "Acerca de Nosotros"
            });
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}

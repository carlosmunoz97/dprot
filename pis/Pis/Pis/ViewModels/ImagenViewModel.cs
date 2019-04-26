using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Pis.ViewModels
{
    public class ImagenViewModel : BaseViewModel
    {
        #region Atributes
        private ObservableCollection<ImagenesViewModel> listai;
        private bool isRefreshing;
        private bool isEnabled;
        #endregion

        #region Properties
        public ObservableCollection<ImagenesViewModel> Listai
        {
            get { return this.listai; }
            set { SetValue(ref this.listai, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public ImagenViewModel()
        {
            this.IsEnabled = true;
            this.LoadListai();
        }
        #endregion

        #region Methods
        private void LoadListai()
        {
            this.IsRefreshing = true;
            this.IsEnabled = true;
            this.Listai = new ObservableCollection<ImagenesViewModel>();
            if (varGlobal.img == "sach")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Tobillo sólido con talón blando, unión perfecta entre pie y pierna debido a que no tiene articulaciones móviles",
                    Title = "Pie SACH"
                });
            }

            if (varGlobal.img == "articulado")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Pie articulado uniaxial en aluminio o titanio",
                    Title = "Pie articulado"
                });
            }

            if (varGlobal.img == "multiaxial")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Pie articulado multiaxial de respuesta dinámica alta (en carbono, con resistencia definida por el técnico)",
                    Title = "Pie articulado multiaxial de respuesta dinámica"
                });
            }

            if (varGlobal.img == "ptb")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Encaje hecho de plástico laminado termoformado que proporciona una adaptación íntima sobre la superficie del muñón, incluyendo el extremo distal.",
                    Title = "Encaje de apoyo en el tendón rotuliano (PTB)"
                });
            }

            if (varGlobal.img == "supracondilea")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Sujeta al encaje en las áreas posteromedial y posterolateral, envuelve el muslo por encima de los epicóndilos y la rótula",
                    Title = "Correa suprancondilea"
                });
            }

            if (varGlobal.img == "modular")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Se usan componentes intercambiables estandarizados hechos de aluminio o titanio",
                    Title = "Exoesquelético modular"
                });
            }

            if (varGlobal.img == "pin")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Se usa un liner con pin asegurado por una lanzadera en su parte inferior para mayor sujeción",
                    Title = "Pin y lanzadera"
                });
            }

            if (varGlobal.img == "silicona")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Interface hecha de silicona",
                    Title = "Silicona"
                });
            }

            if (varGlobal.img == "vacio")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Se usa en pacientes con buena musculatura y fuerza, ofrece mayor libertad de movimiento y comodidad (se adapta a la velocidad de la marcha)",
                    Title = "Válvula de vacío"
                });
            }

            if (varGlobal.img == "copolimero")
            {
                this.Listai.Add(new ImagenesViewModel
                {
                    Image = "uno.png",
                    Description = "Interface hecha de copolímero",
                    Title = "Copolímero"
                });
            }

            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadListai);
            }
        }
        #endregion
    }
}

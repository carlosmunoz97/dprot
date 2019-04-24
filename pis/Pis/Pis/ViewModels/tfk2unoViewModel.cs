﻿using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pis.ViewModels
{
    public class tfk2unoViewModel : BaseViewModel
    {
        #region Attributes
        private bool isEnabled;
        #endregion

        #region Properties
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Commands
        public ICommand Alerta1Command
        {
            get
            {
                return new RelayCommand(alerta1);
            }
        }
        public ICommand Alerta2Command
        {
            get
            {
                return new RelayCommand(alerta2);
            }
        }
        public ICommand Alerta3Command
        {
            get
            {
                return new RelayCommand(alerta3);
            }
        }
        public ICommand Alerta4Command
        {
            get
            {
                return new RelayCommand(alerta4);
            }
        }
        public ICommand Alerta5Command
        {
            get
            {
                return new RelayCommand(alerta5);
            }
        }
        public ICommand Alerta6Command
        {
            get
            {
                return new RelayCommand(alerta6);
            }
        }

        private async void alerta1()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Fibra de carbono",
                "Diseño cuadrilátero o de contención isquiática (ovoidea)",
                "aceptar");
            return;
        }
        private async void alerta2()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Válvula de vacío",
                "Se usa en pacientes con buena fuerza y musculatura ya que genera mayor libertad de movimiento y comodidad (se adapta a la velocidad de la marcha)",
                "aceptar");
            return;
        }
        private async void alerta3()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Encaje flexible",
                "Se usa con el fin de distribuir la presión en el muñón",
                "aceptar");
            return;
        }
        private async void alerta4()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Monocéntrica de freno a la carga",
                "Hecha de aluminio o titanio",
                "aceptar");
            return;
        }
        private async void alerta5()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Aluminio o titanio",
                "Se usan componentes intercambiables estandarizados hechos de aluminio o titanio",
                "aceptar");
            return;
        }
        private async void alerta6()
        {
            this.isEnabled = true;

            await Application.Current.MainPage.DisplayAlert(
                "Pie articulado de respuesta dinámica",
                "Pie articulado en carbono de respuesta dinámica media",
                "aceptar");
            return;
        }
        #endregion

        #region Constructors
        public tfk2unoViewModel()
        {
            this.IsEnabled = true;
        }
        #endregion
    }
}

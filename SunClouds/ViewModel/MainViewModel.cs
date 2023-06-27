using SunClouds;
using StylesLib;
using SunClouds.ViewModel.Helpers;
using System.Globalization;
using System.Windows.Media;
using SunClouds.Properties;
using System.Collections.Generic;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SunClouds.View;

namespace SunClouds.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Свойства
        private string textSymb; // значение TextBox
        public string TextSymb
        {
            get { return textSymb; }
            set
            {
                if (textSymb != value)
                {
                    textSymb = value;
                    OnPropertyChanged();
                }
            }
        }


        #endregion
        #region commands
        public event EventHandler onRequestClose;
        public BindableCommand ExitCommand { get; set; }
        public BindableCommand SaveParameterCommand { get; set; } // Действие для сохранения параметра
        #endregion

        public MainViewModel()
        {
            TextSymb = Settings.Default.City;

            SaveParameterCommand = new BindableCommand(_ => SaveParameter());
            ExitCommand = new BindableCommand(_ => onRequestClose(this, new EventArgs()));
            
        }   
        private void SaveParameter() // Метод для сохранения города в параметрах
        {
            if (string.IsNullOrEmpty(TextSymb))
                return;

            Settings.Default.City = TextSymb;
            Settings.Default.Save();
            
            new WeatherWindow().Show(); // Открытие нового окна погоды
            ExitCommand.Execute(this); // Исполнение команды закрытия прошлого окна
        }
    }
}
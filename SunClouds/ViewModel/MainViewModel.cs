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
        public event EventHandler onRequestClose;
        #region commands
        public BindableCommand ExitCommand { get; set; }
        public BindableCommand SaveParameterCommand { get; set; } // Действие для сохранения параметра
        public BindableCommand LostFocusCommand { get; set; } // Действие, когда наводишься уже на другой элемент
        public BindableCommand PreviewMouseDownCommand { get; set; } // Действие, когда нажимаешь на TextBox
        #endregion

        public MainViewModel()
        {
            TextSymb = Settings.Default.City;

            SaveParameterCommand = new BindableCommand(_ => SaveParameter());
            LostFocusCommand = new BindableCommand(TextBoxLostFocus);
            PreviewMouseDownCommand = new BindableCommand(TextBoxPreviewMouseDown);
            ExitCommand = new BindableCommand(_ => onRequestClose(this, new EventArgs()));
            
        }   

        private void TextBoxLostFocus(object parameter) // Метод для действий, связанных с LostFocus
        {
            if (string.IsNullOrEmpty(TextSymb))
                TextSymb = "Ваш город";
            
        }

        private void TextBoxPreviewMouseDown(object parameter) // Метод для действий, связанных c PrewiewMouseDownCommand
        {
            if (TextSymb == "Ваш город" || TextSymb == Settings.Default.City)
                TextSymb = "";
            
        }
        private void SaveParameter() // Метод для сохранения города в параметрах
        {
            //if (string.IsNullOrEmpty(TextSymb) && TextSymb != "Ваш город")
            //    return;
            
            //Settings.Default.City = TextSymb;
            //Settings.Default.Save();
            new WeatherWindow().Show(); // Открытие нового окна погоды
            ExitCommand.Execute(this); // Исполнение команды закрытия прошлого окна
        }
    }
}
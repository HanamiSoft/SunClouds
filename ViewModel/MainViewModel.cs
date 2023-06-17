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

        public BindableCommand SaveParameterCommand { get; set; } // Действие для сохранения параметра
        public BindableCommand LostFocusCommand { get; set; } // Действие, когда наводишься уже на другой элемент
        public BindableCommand PreviewMouseDownCommand { get; set; } // Действие, когда нажимаешь на TextBox

        public MainViewModel()
        {
            TextSymb = SunClouds.Properties.Settings.Default.City;

            SaveParameterCommand = new BindableCommand(_ => SaveParameter());
            LostFocusCommand = new BindableCommand(TextBoxLostFocus);
            PreviewMouseDownCommand = new BindableCommand(TextBoxPreviewMouseDown);
        }

        private void TextBoxLostFocus(object parameter) // Метод для действий, связанных с LostFocus
        {
            if (string.IsNullOrEmpty(TextSymb))
            {
                TextSymb = "Ваш город";
            }
        }

        private void TextBoxPreviewMouseDown(object parameter) // Метод для действий, связанных c PrewiewMouseDownCommand
        {
            if (TextSymb == "Ваш город" || TextSymb == SunClouds.Properties.Settings.Default.City)
            {
                TextSymb = "";
            }
        }
        private void SaveParameter() // Метод для сохранения города в параметрах
        {
            if (!string.IsNullOrEmpty(TextSymb) && TextSymb != "Ваш город")
            {
                SunClouds.Properties.Settings.Default.City = TextSymb;
                SunClouds.Properties.Settings.Default.Save();
            }
        }
    }
}


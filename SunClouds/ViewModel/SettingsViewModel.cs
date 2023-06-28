using SunClouds.Properties;
using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.ViewModel
{

    class SettingsViewModel : BindingHelper
    {
        #region Свойства
        private bool isCelsiusChecked = Settings.Default.Celsius;

        public bool IsCelsiusChecked
        {
            get { return isCelsiusChecked; }
            set 
            {
                isCelsiusChecked = value;
                isFahrenheitChecked = !isCelsiusChecked;
                OnPropertyChanged();
            }
        }
        private bool isFahrenheitChecked = Settings.Default.Fahrenheit;

        public bool IsFahrenheitChecked
        {
            get { return isFahrenheitChecked; }
            set 
            {
                isFahrenheitChecked = value;
                isCelsiusChecked = !isFahrenheitChecked;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<FavouriteCitiesModel> Items { get;} = new ObservableCollection<FavouriteCitiesModel>();
        #endregion
        #region commands
        public BindableCommand CSelected { get; set; }
        public BindableCommand FSelected { get; set; }
        public BindableCommand SaveParameterCommand { get; set; } // Действие для сохранения параметра
        #endregion
        public SettingsViewModel()
        {
            SaveParameterCommand = new BindableCommand(_ =>
            {
                Settings.Default.Fahrenheit = isFahrenheitChecked;
                Settings.Default.Celsius = isCelsiusChecked;
                Settings.Default.Save();
            });
            
            CSelected = new BindableCommand(_ => IsCelsiusChecked = true);
            FSelected = new BindableCommand(_ => IsFahrenheitChecked = true);
            
        }
    }
}

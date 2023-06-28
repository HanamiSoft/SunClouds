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
        private string textSymb1; // значение TextBox
        public string TextSymb1
        {
            get { return textSymb1; }
            set
            {
                if (textSymb1 != value)
                {
                    textSymb1 = value;
                    OnPropertyChanged();
                }
            }
        }
        private string textSymb2; // значение TextBox
        public string TextSymb2
        {
            get { return textSymb2; }
            set
            {
                if (textSymb2 != value)
                {
                    textSymb2 = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region commands
        public BindableCommand ClearText { get; set; }
        public BindableCommand SetFavouriteCountry { get; set; }
        public BindableCommand ClearText2 { get; set; }
        #endregion

        public ObservableCollection<FavouriteCitiesModel> Items { get;} = new ObservableCollection<FavouriteCitiesModel>();

        public SettingsViewModel()
        {
            // Добавьте элементы в коллекцию

            ClearText = new BindableCommand(_ => ClearTextFunction());
            ClearText2 = new BindableCommand(_ => ClearTextFunction2());
            SetFavouriteCountry = new BindableCommand(_ => SetFavouriteCountryFunction());
        }

        private void ClearTextFunction()
        {
            TextSymb1 = "";
        }
        private void ClearTextFunction2()
        {
            TextSymb2 = "";
        }
        private void SetFavouriteCountryFunction() 
        {
            Items.Add(new FavouriteCitiesModel { Country = TextSymb1, Shirota = TextSymb2 });
        }
    }
}

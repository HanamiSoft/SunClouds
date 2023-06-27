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

        public ObservableCollection<FavouriteCitiesModel> Items { get;} = new ObservableCollection<FavouriteCitiesModel>();

        public SettingsViewModel()
        {
            // Добавьте элементы в коллекцию
            Items.Add(new FavouriteCitiesModel {  });
            Items.Add(new FavouriteCitiesModel { Country = "Item 2", Shirota = "Shirota 2" });
            Items.Add(new FavouriteCitiesModel { Country = "Item 3", Shirota = "Shirota 3" });
            Items.Add(new FavouriteCitiesModel { Country = "Item 3", Shirota = "Shirota 3" });
            Items.Add(new FavouriteCitiesModel { Country = "Item 3", Shirota = "Shirota 3" });
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

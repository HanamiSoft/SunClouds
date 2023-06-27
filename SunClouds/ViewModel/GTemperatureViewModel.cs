using LiveCharts;
using SunClouds.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.ViewModel
{
    internal class GTemperatureViewModel : BindingHelper
    {
        public string[] Times { get; set; }
        public ChartValues<int> Degs { get; set; }
        public GTemperatureViewModel() 
        {
            
        }

    }
}

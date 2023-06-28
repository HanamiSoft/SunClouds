using SunClouds.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SunClouds.View
{
    /// <summary>
    /// Логика взаимодействия для FeelingUC.xaml
    /// </summary>
    public partial class FeelingUC : UserControl
    {
        public FeelingUC(string textContent, string dataContent)
        {
            InitializeComponent();
            DataContext = new FeelingUCViewModel(textContent, dataContent);
        }
    }
}

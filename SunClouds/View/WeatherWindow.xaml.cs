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
using System.Windows.Shapes;
using SunClouds.ViewModel;


namespace SunClouds.View
{
    /// <summary>
    /// Логика взаимодействия для WeatherWindow.xaml
    /// </summary>
    public partial class WeatherWindow : Window
    {
        public WeatherWindow()
        {
            InitializeComponent();
            DataContext = new WeatherViewModel();
            Loaded += MainWindow_Loaded; // Обработчик события для страницы
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            Pages.Content = new SettingsPage(); // Отображение страницы для примера
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                (sender as WeatherWindow).DragMove();
            }
        }
    }
}

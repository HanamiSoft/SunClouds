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
using System.Windows.Media.Animation;
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
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                (sender as WeatherWindow).DragMove();
            }
        }
        
        async private void Clouse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1.0;
            animation.To = 0.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            this.BeginAnimation(UIElement.OpacityProperty, animation);

            await Task.Delay(300); // задержка на 0,3 секунды



            animation = new DoubleAnimation();
            animation.From = 0.0;
            animation.To = 1.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            this.BeginAnimation(UIElement.OpacityProperty, animation);

            this.Close();
        }

        async private void Minus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1.0;
            animation.To = 0.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            this.BeginAnimation(UIElement.OpacityProperty, animation);

            await Task.Delay(300); // задержка на 0,3 секунды

            this.WindowState = WindowState.Minimized;

            animation = new DoubleAnimation();
            animation.From = 0.0;
            animation.To = 1.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            this.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        async private void screen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1.0;
            animation.To = 0.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            this.BeginAnimation(UIElement.OpacityProperty, animation);

            await Task.Delay(300); // задержка на 0,3 секунды



            animation = new DoubleAnimation();
            animation.From = 0.0;
            animation.To = 1.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(0.5));

            this.BeginAnimation(UIElement.OpacityProperty, animation);

            if (WindowState == WindowState.Maximized)
            {

                WindowState = WindowState.Normal;




                Topmost = false;
            }
            else
            {

                WindowState = WindowState.Maximized;




                Topmost = true;
            }
        }
    }
}

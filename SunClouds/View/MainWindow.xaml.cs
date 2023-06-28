﻿using SunClouds.ViewModel;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SunClouds
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            DataContext = vm;
            vm.onRequestClose += (s, e) => this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                (sender as MainWindow).DragMove();
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
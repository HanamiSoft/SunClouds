﻿using SunClouds.ViewModel;
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
    /// Логика взаимодействия для UserFavouriteCities.xaml
    /// </summary>
    public partial class UserFavouriteCities : UserControl
    {
        public UserFavouriteCities()
        {
            InitializeComponent();
            DataContext = new FavouriteCitiesModel();
        }
    }
}

﻿using RussianRoadsGUI.Views.Pages;
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

namespace RussianRoadsGUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            main.Navigate(new TreePage());
        }

        private void btnCalendarOne_Click(object sender, RoutedEventArgs e)
        {

            TreePage treePage = new TreePage();
            treePage.calEvent.Visibility = Visibility.Hidden;
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

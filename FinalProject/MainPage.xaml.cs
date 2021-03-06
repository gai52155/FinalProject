﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace FinalProject
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
    }
        private void changeNavBtn(object sender, RoutedEventArgs e)
        {
            Button theButton = sender as Button;
            string url = theButton.Tag.ToString();

            this.navFrame.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}

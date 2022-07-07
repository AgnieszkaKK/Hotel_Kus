﻿using System;
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

namespace Hotel_Kus
{
    /// <summary>
    /// Logika interakcji dla klasy Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Klienci klienci = new Klienci();
            this.NavigationService.Navigate(klienci);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rezerwacja rezerwacja = new Rezerwacja();
            this.NavigationService.Navigate(rezerwacja);
        }


    }
}

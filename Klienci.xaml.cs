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
using System.Data.Entity;

namespace Hotel_Kus
{
    /// <summary>
    /// Logika interakcji dla klasy Klienci.xaml
    /// </summary>
    public partial class Klienci : Page
    {
        Entity_Hotel_Kus context = new Entity_Hotel_Kus();
        CollectionViewSource clientViewSource;
        // CollectionViewSource ordViewSource;
        public Klienci()
        {
            InitializeComponent();
            clientViewSource = ((CollectionViewSource)(FindResource("listaKlientowViewSource")));
            DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            context.ListaKlientow.Load();

            clientViewSource.Source = context.ListaKlientow.Local;
        }
    }

}

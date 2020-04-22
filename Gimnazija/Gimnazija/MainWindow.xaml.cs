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

namespace Gimnazija
{
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
    { 
            public MainWindow()
            { /*InitializeComponent();*/}
            private void MenuItemGimnazijaa_Click(object sender, RoutedEventArgs e)
            {
            Gimnazijaa objGimnazijaa = new Gimnazijaa();
                objGimnazijaa.Show();
            }
            private void MenuItemUcenik_Click(object sender, RoutedEventArgs e)
            {
            Ucenik objUcenik = new Ucenik();
                objUcenik.Show();
            }
           
            private void MenuItemPredmet_Click(object sender, RoutedEventArgs e)
            {
                Predmet objPredmet = new Predmet();
                objPredmet.Show();
            }
            private void MenuItemDnevnik_Click(object sender, RoutedEventArgs e)
            {
                Dnevnik objDnevnik = new Dnevnik();
                objDnevnik.Show();
            }
        private void MenuItemNastavnik_Click(object sender, RoutedEventArgs e)
        {
            Nastavnik objNastavnik = new Nastavnik();
            objNastavnik.Show();
        }
    }
    }

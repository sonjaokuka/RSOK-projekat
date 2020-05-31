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

namespace Cvecara
{
    /// <summary>
    /// Interaction logic for KupiProzor.xaml
    /// </summary>
    public partial class KupiProzor : Window
    {
        public KupiProzor(string title, string price, string sort, DateTime date)
        {
            InitializeComponent();
            nazivTxt.Text = title;
            cenaTxt.Text = price;
            vrstaTxt.Text = sort;
            datumTxt.Text = date.ToString();
            
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MessageBox.Show("Uspesno ste narucili proizvod");
        }
    }
}

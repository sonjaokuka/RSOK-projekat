using Cvecara.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Cvecara
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Korisnik user = new Korisnik();
        public MainWindow(Korisnik user)
        {
            InitializeComponent();
            prikazCveca();
            this.user = user;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if(user.isAdmin == "Yes")
            {
                DodajProizvod dodaj = new DodajProizvod();
                dodaj.Show();
            }
            else
            {
                MessageBox.Show("Nemate dozvolu za to", "Error");
            }
            
        }
     
        private void Lokacija_Click(object sender, RoutedEventArgs e)
        {
            Lokacija lokacija = new Lokacija();
            lokacija.Show();
        }
        private void prikazCveca()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT idCveca, naziv, cena, vrsta FROM Cvece";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable("Cvece");
                        dataAdapter.Fill(dataTable);

                        CveceDataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
        }
        private void CveceDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtNaziv.Text = dr["Naziv"].ToString();
                txtCena.Text = dr["Cena"].ToString();
                txtVrsta.Text = dr["Vrsta"].ToString();
               
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KupiProzor kupi = new KupiProzor(txtNaziv.Text, txtCena.Text, txtVrsta.Text, picker.SelectedDate.Value.Date);
            kupi.Show();
        }

  
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
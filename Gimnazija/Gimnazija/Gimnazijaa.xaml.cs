using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;
namespace Gimnazija
{

    public partial class Gimnazijaa : Window
    {

        public Gimnazijaa()
        {
            InitializeComponent();
            prikaziGimnazije();
        }

        private void prikaziGimnazije()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [T_Gimnazija]";
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("T_Gimnazija");
            dataAdapter.Fill(dataTable);

            DataGridGimnazijaa.ItemsSource = dataTable.DefaultView;
        }

        private void ponistiUnosTxt()
        {
            txtidGimnazije.Text = "";
            txtNaziv.Text = "";
            txtGrad.Text = "";
            txtAdresa.Text = "";
            
        }

        private void DataGridGimnazijaa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtidGimnazije.Text = dr["IdGimnazije"].ToString();
                txtNaziv.Text = dr["Naziv"].ToString();
                txtGrad.Text = dr["Grad"].ToString();
                txtAdresa.Text = dr["Adresa"].ToString();
             
            }
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString; 
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO [T_Gimnazija] (Naziv, Grad, Adresa) VALUES (@Naziv, @Grad, @Adresa)";
            command.Parameters.AddWithValue("@Naziv", txtNaziv.Text);
            command.Parameters.AddWithValue("@Grad", txtGrad.Text);
            command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
            
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci su uspešno upisani");
                prikaziGimnazije();
            }
            ponistiUnosTxt();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [T_Gimnazija] SET Naziv=@Naziv, Grad=@Grad, Adresa=@Adresa WHERE IdGimnazije=@IdGimnazije";
            command.Parameters.AddWithValue("@IdGimnazije", txtidGimnazije.Text);
            command.Parameters.AddWithValue("@Naziv", txtNaziv.Text);
            command.Parameters.AddWithValue("@Grad", txtGrad.Text);
            command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);


            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci su uspešno izmenjeni");
                prikaziGimnazije();
            }
            ponistiUnosTxt();
        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM [T_Gimnazija]  WHERE IdGimnazije=@IdGimnazije";
            command.Parameters.AddWithValue("@IdGimnazije", txtidGimnazije.Text);
            
           
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci uspešno obrisani");
                prikaziGimnazije();
            }
            ponistiUnosTxt();
        }


    }
}


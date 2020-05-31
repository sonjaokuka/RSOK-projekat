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
namespace Cvecara
{
    /// <summary>
    /// Interaction logic for Lokacija.xaml
    /// </summary>
    public partial class Lokacija : Window
    {
        public Lokacija()
        {
            InitializeComponent();
            prikazLokacije();
        }
        private void prikazLokacije()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT idLokacije, telefon, adresa, grad FROM Lokacija ";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable("Lokacija");
                        dataAdapter.Fill(dataTable);

                        LokacijaDataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
        }


        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Lokacija (Telefon, Adresa, Grad) VALUES(@Telefon, @Adresa, @Grad)";
                    command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
                    command.Parameters.AddWithValue("@Grad", txtGrad.Text);
                    command.Connection = connection;

                    int provera = command.ExecuteNonQuery();
                    if (provera == 1)
                    {
                        MessageBox.Show("Podaci su uspesno upisani");
                        prikazLokacije();
                    }
                    ponistiUnosTxt();
                }
            }

        }

        private void Obrisi_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Lokacija WHERE idLokacije = @idLokacije";
                    command.Parameters.AddWithValue("@idLokacije", txtidLokacije.Text);
                    command.Connection = connection;

                    int provera = command.ExecuteNonQuery();
                    if (provera == 1)
                    {
                        MessageBox.Show("Podaci su uspesno obrisani");
                        prikazLokacije();
                    }
                    ponistiUnosTxt();
                }
            }
        }
        private void Izmeni_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Lokacija SET Telefon = @telefon, Adresa = @adresa, Grad = @grad WHERE idLokacije = @idLokacije";
                    command.Parameters.AddWithValue("@idLokacije", txtidLokacije.Text);
                    command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    command.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
                    command.Parameters.AddWithValue("@Grad", txtGrad.Text);
                    command.Connection = connection;

                    int provera = command.ExecuteNonQuery();
                    if (provera == 1)
                    {
                        MessageBox.Show("Podaci su uspesno promenjeni");
                        prikazLokacije();
                    }
                    ponistiUnosTxt();
                }
            }
        }
        private void ponistiUnosTxt()
        {
            txtTelefon.Text = "";
            txtAdresa.Text = "";
            txtGrad.Text = "";
        }
        private void LokacijaDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtTelefon.Text = dr["Telefon"].ToString();
                txtAdresa.Text = dr["Adresa"].ToString();
                txtGrad.Text = dr["Grad"].ToString();
                txtidLokacije.Text = dr["idLokacije"].ToString();
            }
        }

       
}
}




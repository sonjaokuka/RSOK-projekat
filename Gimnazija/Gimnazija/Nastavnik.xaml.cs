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
    public partial class Nastavnik : Window
    {

        public Nastavnik()
        {
            InitializeComponent();
            prikaziNastavnike();
        }

    
        private void prikaziNastavnike()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [T_Nastavnik]";
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("T_Nastavnik");
            dataAdapter.Fill(dataTable);

            DataGridNastavnik.ItemsSource = dataTable.DefaultView;
        }

        private void ponistiUnosTxt()
        {
            txtidNastavnika.Text = "";
            txtImeNastavnika.Text = "";
            txtPrezimeNastavnika.Text = "";
            txtemail.Text = "";

        }

        private void DataGridNastavnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtidNastavnika.Text = dr["IdNastavnika"].ToString();
                txtImeNastavnika.Text = dr["ImeNastavnika"].ToString();
                txtPrezimeNastavnika.Text = dr["PrezimeNastavnika"].ToString();
                txtemail.Text = dr["email"].ToString();

            }
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO [T_Nastavnik] (ImeNastavnika, PrezimeNastavnika, email) VALUES (@Ime, @Prezime, @email)";
            command.Parameters.AddWithValue("@Ime", txtImeNastavnika.Text);
            command.Parameters.AddWithValue("@Prezime", txtPrezimeNastavnika.Text);
            command.Parameters.AddWithValue("@email", txtemail.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci su uspešno upisani");
                prikaziNastavnike();
            }
            ponistiUnosTxt();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [T_Nastavnik] SET ImeNastavnika=@Ime, PrezimeNastavnika=@Prezime, email=@email WHERE IdNastavnika=@IdNastavnika";
            command.Parameters.AddWithValue("@IdNastavnika", txtidNastavnika.Text);
            command.Parameters.AddWithValue("@Ime", txtImeNastavnika.Text);
            command.Parameters.AddWithValue("@Prezime", txtPrezimeNastavnika.Text);
            command.Parameters.AddWithValue("@email", txtemail.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci su uspešno izmenjeni");
                prikaziNastavnike();
            }
            ponistiUnosTxt();
        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM [T_Nastavnik] WHERE IdNastavnika = @IdNastavnika";
            command.Parameters.AddWithValue("@IdNastavnika", txtidNastavnika.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci uspešno obrisani");
                prikaziNastavnike();
            }
            ponistiUnosTxt();
        }
    }
}
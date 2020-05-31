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
    /// Interaction logic for DodajProizvod.xaml
    /// </summary>
    public partial class DodajProizvod : Window
    {
        public DodajProizvod()
        {
            InitializeComponent();
            prikazCveca();
            
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
       

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                connection.Open();
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Cvece (Naziv, Vrsta, Cena) VALUES(@Naziv, @Vrsta, @Cena)";
                    command.Parameters.AddWithValue("@Naziv", txtNaziv.Text);
                    command.Parameters.AddWithValue("@Cena", txtCena.Text);
                    command.Parameters.AddWithValue("@Vrsta", txtVrsta.Text);
                    command.Connection = connection;

                    int provera = command.ExecuteNonQuery();
                    if (provera == 1)
                    {
                        MessageBox.Show("Podaci su uspešno upisani");
                        prikazCveca();
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
                    command.CommandText = "DELETE FROM Cvece WHERE idCveca = @idCveca";
                    command.Parameters.AddWithValue("@idCveca", txtidCveca.Text);
                    command.Connection = connection;

                    int provera = command.ExecuteNonQuery();
                    if (provera == 1)
                    {
                        MessageBox.Show("Podaci su uspesno obrisani");
                        prikazCveca();
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
                    command.CommandText = "UPDATE Cvece SET Naziv = @naziv, Cena = @cena, Vrsta = @vrsta WHERE idCveca = @idCveca";
                    command.Parameters.AddWithValue("@idCveca", txtidCveca.Text);
                    command.Parameters.AddWithValue("@naziv", txtNaziv.Text);
                    command.Parameters.AddWithValue("@cena", txtCena.Text);
                    command.Parameters.AddWithValue("@vrsta", txtVrsta.Text);
                    command.Connection = connection;

                    int provera = command.ExecuteNonQuery();
                    if (provera == 1)
                    {
                        MessageBox.Show("Podaci su uspesno promenjeni");
                        prikazCveca();
                    }
                    ponistiUnosTxt();
                }
            }
        }
        private void ponistiUnosTxt()
        {
            txtNaziv.Text = "";
            txtCena.Text = "";
            txtVrsta.Text = "";
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
                txtidCveca.Text = dr["idCveca"].ToString();
            }
        }
    }
}

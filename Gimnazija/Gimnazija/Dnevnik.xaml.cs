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
    /// <summary>
    /// Interaction logic for Rekordi.xaml
    /// </summary>
    public partial class Dnevnik: Window
    {
        public Dnevnik()
        {
            InitializeComponent();
            prikaziDnevnike();
        }
        private void prikaziDnevnike()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [T_Dnevnik]"; 
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("T_Dnevnik");
            dataAdapter.Fill(dataTable);

            DataGridDnevnik.ItemsSource = dataTable.DefaultView;
        }
        private void ponistiUnosTxt()
        {
            txtidDnevnika.Text = "";
            txtImeUcenika.Text = "";
            txtPrezimeUcenika.Text = "";
            txtOcena.Text = "";
            txtRazred.Text = "";
            dtDatum.Text = "";
            txtNazivPredmeta.Text = "";

        }

        private void DataGridDnevnik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtidDnevnika.Text = dr["IdDnevnika"].ToString();
                txtImeUcenika.Text = dr["ImeUcenika"].ToString();
                txtPrezimeUcenika.Text = dr["PrezimeUcenika"].ToString();
                txtOcena.Text = dr["Ocena"].ToString();
                txtRazred.Text = dr["Razred"].ToString();
                dtDatum.Text = dr["Datum"].ToString();
                txtNazivPredmeta.Text = dr["NazivPredmeta"].ToString();
                



            }
        }
        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO [T_Dnevnik] (ImeUcenika, PrezimeUcenika, NazivPredmeta, Razred, Ocena, Datum ) VALUES (@ImeUcenika, @PrezimeUcenika, @NazivPredmeta, @Razred, @Ocena, @Datum )";
            command.Parameters.AddWithValue("@NazivPredmeta", txtNazivPredmeta.Text);
            command.Parameters.AddWithValue("@ImeUcenika", txtImeUcenika.Text);
            command.Parameters.AddWithValue("@PrezimeUcenika", txtPrezimeUcenika.Text);
            command.Parameters.AddWithValue("@Razred", txtRazred.Text);
            command.Parameters.AddWithValue("@Ocena", txtOcena.Text);
            command.Parameters.AddWithValue("@Datum", dtDatum.Text);
            //command.Parameters.AddWithValue("@PrezimeTrenera", comboBoxTrener.Text);

            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci su uspešno upisani");
                prikaziDnevnike();
            }
            ponistiUnosTxt();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE [T_Dnevnik] SET ImeUcenika = @ImeUcenika, PrezimeUcenika=@PrezimeUcenika, NazivPredmeta = @NazivPredmeta, Razred=@Razred, Ocena=@Ocena, Datum=@Datum WHERE IdDnevnika = @IdDnevnika";
            command.Parameters.AddWithValue("@IdDnevnika", txtidDnevnika.Text);
            command.Parameters.AddWithValue("@ImeUcenika", txtImeUcenika.Text);
            command.Parameters.AddWithValue("@PrezimeUcenika", txtPrezimeUcenika.Text);
            command.Parameters.AddWithValue("@NazivPredmeta", txtNazivPredmeta.Text);
            command.Parameters.AddWithValue("@Razred", txtRazred.Text);
            command.Parameters.AddWithValue("@Ocena", txtOcena.Text);
            command.Parameters.AddWithValue("@Datum", dtDatum.Text);
            //command.Parameters.AddWithValue("@PrezimeTrenera", comboBoxTrener.Text);

            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci su uspešno izmenjeni");
                prikaziDnevnike();
            }
            ponistiUnosTxt();
        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connMUZICKASKOLA"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM [T_Dnevnik] WHERE IdDnevnika = @IdDnevnika";
            command.Parameters.AddWithValue("@IdDnevnika", txtidDnevnika.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci uspešno obrisani");
                prikaziDnevnike();
            }
            ponistiUnosTxt();
        }
      

        /* private void DatePicker_Loaded(object sender, RoutedEventArgs e)
         {
             SqlConnection connection = new SqlConnection();
             connection.ConnectionString = ConfigurationManager.ConnectionStrings["connPSS"].ConnectionString;
             connection.Open();
             SqlCommand commandCbx = new SqlCommand();
             commandCbx.CommandText = "SELECT * FROM [T_Ucenik] ORDER BY dtDatum";
             commandCbx.Connection = connection;
             SqlDataAdapter dataAdapterCbx = new SqlDataAdapter(commandCbx);
             DataTable dataTableCbx = new DataTable("T_Dnevnik");
             dataAdapterCbx.Fill(dataTableCbx);
             for (int i = 0; i < dataTableCbx.Rows.Count; i++)
             {
                 DataPickerTakmicenje.DataContext.Equals(dataTableCbx.Rows[i]["dtDatum"]);
             }
         }*/


    }
}

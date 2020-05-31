using System;
using System.Collections.Generic;
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
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Window
    {
        private string isAdmin;
        public Registracija()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (Admin.IsChecked == true)
            {
                isAdmin = "Yes";
            }
            else
            {
                isAdmin = "No";
            }
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                sqlConnection.Open();

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    if (txtLozinka.Password.Equals(txtPonovi.Password))
                    {
                        command.CommandText = "Insert into Kupac([KorisnickoIme], [Lozinka], [isAdmin]) values (@Username,@Password,@isAdmin)";
                        command.Parameters.AddWithValue("@Username", txtKorisnickoime.Text);
                        command.Parameters.AddWithValue("@Password", txtLozinka.Password);
                        command.Parameters.AddWithValue("@isAdmin", isAdmin);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Lozinke se ne poklapaju!");
                    }
                }

            }
            Close();
        }
    }
}

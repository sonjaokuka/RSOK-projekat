using Cvecara.models;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Prijavi_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                sqlConnection.Open();

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Select count(1) from Kupac where KorisnickoIme=@Username and Lozinka=@Password";
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Password);
                    if (Convert.ToInt32(command.ExecuteScalar()) == 1)
                    {
                        MainWindow main = new MainWindow(GetUserContents());
                        main.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect!");
                    }
                }
            }
        }

        private Korisnik GetUserContents()
        {
            Korisnik user = new Korisnik();
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=WIN7-PC\\SQLEXPRESS;Initial Catalog=Cvecara;Integrated Security=True"))
            {
                sqlConnection.Open();

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "Select * from Kupac where KorisnickoIme=@Username and Lozinka=@Password";
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = (int)reader["idKupca"];
                            user.Username = reader["KorisnickoIme"] as string;
                            user.Password = reader["Lozinka"] as string;
                            user.isAdmin = reader["isAdmin"] as string;
                        }

                    }
                }
            }
            return user;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
        }
    }
    
}

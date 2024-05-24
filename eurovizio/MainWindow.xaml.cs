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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace eurovizio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string kapcsolatLeiro = "datasource=127.0.0.1;port=3306;username=root;password=;database=eurovizio;charset=utf8;";
        private MySqlConnection connection;
        List<Dal> dalok;
        List<Verseny> versenyek;
        public MainWindow()
        {
            InitializeComponent();
            adatokBetoltese();
        }
        public void adatokBetoltese()
        {
            dalok = new List<Dal>();
            
            try
            {
                connection = new MySqlConnection(kapcsolatLeiro);
                connection.Open();
                string lekerdezes = "SELECT ev,eloado,cim,helyezes,pontszam FROM dal";
                MySqlCommand kerdez = new MySqlCommand(lekerdezes, connection);
                kerdez.CommandTimeout = 60;
                MySqlDataReader olvas = kerdez.ExecuteReader();
                while (olvas.Read())
                {
                    dalok.Add(new Dal(olvas));
                }
                olvas.Close();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            dgAdatok.ItemsSource = dalok;

            //versenyek = new List<Verseny>();

            //try
            //{
            //    connection = new MySqlConnection(kapcsolatLeiro);
            //    connection.Open();
            //    string lekerdezes = "SELECT ev,datum,varos,orszag,induloszam FROM verseny";
            //    MySqlCommand kerdez = new MySqlCommand(lekerdezes, connection);
            //    kerdez.CommandTimeout = 60;
            //    MySqlDataReader olvas = kerdez.ExecuteReader();
            //    while (olvas.Read())
            //    {
            //        versenyek.Add(new Verseny(olvas));
            //    }
            //    olvas.Close();
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}

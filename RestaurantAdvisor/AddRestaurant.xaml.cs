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

namespace RestaurantAdvisor
{
    /// <summary>
    /// Interaktionslogik für AddRestaurant.xaml
    /// </summary>
    public partial class AddRestaurant : Window
    {
        private string nameOfRestaurant;
        private string addressOfRestaurant;
        private string homepageOfRestaurant;
        private string nationalityOfRestaurant;

        bool table_exists = false;

        public string NameOfRestaurant
        {
            get
            {
                return nameOfRestaurant;
            }
            set
            {
                nameOfRestaurant = value;
            }
        }

        public string AddressOfRestaurant
        {
            get
            {
                return addressOfRestaurant;
            }
            set
            {
                addressOfRestaurant = value;
            }
        }

        public string HomepageOfRestaurant
        {
            get
            {
                return homepageOfRestaurant;
            }
            set
            {
                homepageOfRestaurant = value;
            }
        }

        public string NationalityOfRestaurant
        {
            get
            {
                return nationalityOfRestaurant;
            }
            set
            {
                nationalityOfRestaurant = value;
            }
        }


        public AddRestaurant()
        {
            InitializeComponent();
        }

        public AddRestaurant(string aNameOfRestaurant, string aAddressOfRestaurant, string aHomepageOfRestaurant, string aNationalityOfRestaurant)
        {
            NameOfRestaurant = aNameOfRestaurant;
            AddressOfRestaurant = aAddressOfRestaurant;
            HomepageOfRestaurant = aHomepageOfRestaurant;
            NationalityOfRestaurant = aNationalityOfRestaurant;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string restaurantName = textBox1.Text.ToString();
            string restaurantAddress = textBox2.Text.ToString();
            string restaurantHomepage = textBox3.Text.ToString();
            string restaurantNationality = textBox4.Text.ToString();
            addToSqlTable(restaurantName, restaurantAddress, restaurantHomepage, restaurantNationality); // ToDo: Continue here with creation of this method and sql table creation/population method
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private bool check_if_table_exists()
        {
            if (table_exists == false)
            {
                return false;
            } else
            {
                createNewTable("New Table");
                return true;
            }
        }

        private void createNewTable(string newTableName)
        {
            SqlConnection conn = connectToSQLDatabase();
            string tableName = "dbo." + newTableName;
            string sql = "CREATE TABLE tableName (" +
                "[Id] INT NOT NULL PRIMARY KEY IDENTITY, [Restaurant Name] NVARCHAR(50)" +
                "[Restaurant Address] NVARCHAR(50), [Restaurant Homepage] NVARCHAR(50), [Restaurant Nationality] NVARCHAR(50)"

        }
        private void addToSqlTable(string restaurantName, string restaurantAddress, string restaurantHomepage, string restaurantNationality)
        {
            check_if_table_exists();
            connectToDatabase();
            addEntries();
            closeDatabase();
            /* Review of Dictionary, Lists, and MessageBoxes plus abbreviations/shortcuts 
             * MessageBox.Show("We transferred the following data to the table: ");
            MessageBox.Show($"Name: {restaurantName} \n" +
                            $"Address: {restaurantAddress} \n " + 
                            $"Homepage: {restaurantHomepage} \n" + 
                            $"Nationality: {restaurantNationality}");
            // ToDo: Continue here and create functionality
            MessageBox.Show("Now I'll present you the entries of the list.");
            List<string> list = new List<string>();
            list.Add(restaurantName);
            list.Add(restaurantAddress);
            list.Add(restaurantHomepage);
            list.Add(restaurantNationality);
            foreach(string detail in list)
            {
                MessageBox.Show(detail);
            }
            MessageBox.Show("Now we'll move on to Dictionaries: ");
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            newDict.Add("Movie A", "Romance");
            newDict.Add("Movie B", "Lyrics");
            foreach(KeyValuePair<string, string> item in newDict)
            {
                MessageBox.Show($"{item.Key}: {item.Value}");
            }
            */
        }
    }
}

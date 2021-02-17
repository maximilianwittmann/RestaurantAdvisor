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

        private SqlConnection connectToSQLDatabase()
        {
            SqlConnection conn = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\\Users\\Admin\\source\\repos\\maximilianwittmann\\RestaurantAdvisor\\RestaurantAdvisor\\Database1.mdf");
            conn.Open();
            MessageBox.Show("CONNECTED to Database");
            return conn;
        }

        private void closeSQLDatabaseConnection(SqlConnection conn)
        {
            conn.Close();
            MessageBox.Show("Database Connection was closed.");
        }

        private bool check_if_table_exists()
        {
            if (table_exists == false)
            {
                createNewTable("Database");
                return true;
            }
            else
            {
                return true;
            }
        }

        private bool createNewTable(string newTableName)
        {
            SqlConnection conn = connectToSQLDatabase();
            string tableName = "dbo." + newTableName;
            string sql = "CREATE TABLE @tableName (" +
                "[Id] INT NOT NULL PRIMARY KEY IDENTITY, [Restaurant_Name] NVARCHAR(50), " +
                "[Restaurant_Address] NVARCHAR(50), [Restaurant_Homepage] NVARCHAR(50), " +
                "[Restaurant_Nationality] NVARCHAR(50))";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@tableName", tableName));
            
            // cmd.Parameters.Add(new SqlParameter("@tableName", tableName));
            cmd.ExecuteNonQuery();
            closeSQLDatabaseConnection(conn);
            MessageBox.Show($"New Table with name {tableName} has been created");
            table_exists = true;
            return table_exists;
            // ToDo: Prevent that two tables called "NewTable" are in the database.
            // Populate New Table and read values
        }
        private void addToSqlTable(string restaurantName, string restaurantAddress, string restaurantHomepage, string restaurantNationality)
        {
            table_exists = check_if_table_exists();

            if (table_exists == true)
            {
                SqlConnection conn = connectToSQLDatabase();

                string sql = "INSERT INTO Database VALUES (name, address, homepage, nationality)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@name", restaurantName));
                cmd.Parameters.Add(new SqlParameter("@address", restaurantAddress));
                cmd.Parameters.Add(new SqlParameter("@homepage", restaurantHomepage));
                cmd.Parameters.Add(new SqlParameter("@nationality", restaurantNationality));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();

                closeSQLDatabaseConnection(conn);
            }
            else
            {
                createNewTable("Database");
            }
        }

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

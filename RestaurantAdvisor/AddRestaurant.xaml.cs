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

        private void addToSqlTable(string restaurantName, string restaurantAddress, string restaurantHomepage, string restaurantNationality)
        {
            MessageBox.Show("We transferred the following data to the table: ");
            MessageBox.Show($"Name: {restaurantName} \n" +
                            $"Address: {restaurantAddress} \n " + 
                            $"Homepage: {restaurantHomepage} \n" + 
                            $"Nationality: {restaurantNationality}");
        }
    }
}

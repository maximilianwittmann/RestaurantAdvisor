using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
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
    /// Interaktionslogik für PlaceNewOrder.xaml
    /// </summary>
    public partial class PlaceNewOrder : Window
    {
        public string RestaurantName { get; set; }

        public string OrderDate { get; set; }

        public string YourOrder { get; set; }

        public string YourRating { get; set; }

        public PlaceNewOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string newRestaurantName = textBox1.Text.ToString();
            string newOrderDate = datePicker1.SelectedDate.ToString();
            string newYourOrder = textBox2.Text.ToString();
            string newYourRating = textBox3.Text.ToString();
            addToSqlTable(newRestaurantName, newOrderDate, newYourOrder, newYourRating);
        }

        public PlaceNewOrder(string aRestaurantName, string aOrderDate, string aYourOrder, string aYourRating)
        {
            RestaurantName = aRestaurantName;
            OrderDate = aOrderDate;
            YourOrder = aYourOrder;
            YourRating = aYourRating;
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

        private void addToSqlTable(string newRestaurantName, string newOrderDate, string newYourOrder, string newYourRating)
        {
            SqlConnection conn = connectToSQLDatabase();

            string sql = "INSERT INTO OrderHistory VALUES (@name, @date, @order, @rating)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@name", newRestaurantName));
            cmd.Parameters.Add(new SqlParameter("@date", newOrderDate));
            cmd.Parameters.Add(new SqlParameter("@order", newYourOrder));
            cmd.Parameters.Add(new SqlParameter("@rating", newYourRating));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();

            closeSQLDatabaseConnection(conn);
        }
    }
}


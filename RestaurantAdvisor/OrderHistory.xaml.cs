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
    /// Interaktionslogik für OrderHistory.xaml
    /// </summary>
    public partial class OrderHistory : Window
    {
        public OrderHistory()
        {
            InitializeComponent();
            displayContent(); 
            // ToDo: This method shall later be edited and not called in here 
            //--> I just want to doublechek if the reading from a specific table and displaying of the entries works
        }

        private void displayContent()
        {
            SqlConnection conn = connectToSQLDatabase();
            string sql = "SELECT * From OrderHistory";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(($"{reader.GetValue(0).ToString()} | {reader.GetString(1)} | {reader.GetString(2)} | {reader.GetString(3)} | {reader.GetString(4)}"));
            }
            closeSQLDatabaseConnection(conn);

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
    }
}

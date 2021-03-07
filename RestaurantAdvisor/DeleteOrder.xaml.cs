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
    /// Interaktionslogik für DeleteOrder.xaml
    /// </summary>
    public partial class DeleteOrder : Window
    {
        public DeleteOrder()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            displayContent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string selectedId = textBox1.Text.ToString();
            listBox1.Items.Clear();
            deleteId(selectedId);
        }

        private void deleteId(string selectedId)
        {
            SqlConnection conn = connectToSQLDatabase();
            string sql = "DELETE From OrderHistory WHERE ID=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@id", selectedId));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            closeSQLDatabaseConnection(conn);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string text = listBox1.SelectedItem.ToString(); 
            // ToDo: Write a method that accepts the listBox selected Items as an Input and returns 
            // only the ID as output; then pass to deleteID method
            List<char> list1 = new List<char>(); // I will iterate through all elements of text string and add single chars to list1
            foreach(char item in text)
            {
                for(int i = 0; i <= 2; i ++)
                {
                    list1.Add(item); // here I add only the first 2 chars to list1
                }
            }
            foreach(char item in list1)
            {
                MessageBox.Show("This is the ID of the selected String: " + item);
            }
            
            
            /* for (int i = 0; i <= lengthInt; i++)
            {
                list1.Add(text[i]);
            }
            List<string> list2 = new List<string>();
            list.Add("Joe");
            list.Add("Sherril");
            foreach (string name in list2)
            {
                MessageBox.Show(name);
            } */
            
        }
    }
}

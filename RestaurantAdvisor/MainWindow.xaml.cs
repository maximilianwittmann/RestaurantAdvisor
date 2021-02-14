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

namespace RestaurantAdvisor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SelectRestaurant selectRestaurant = new SelectRestaurant();
            selectRestaurant.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            AddRestaurant addRestaurant = new AddRestaurant();
            addRestaurant.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DeleteRestaurant deleteRestaurant = new DeleteRestaurant();
            deleteRestaurant.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            OtherAction otherAction = new OtherAction();
            otherAction.Show();
        }

        private void menuItem2Item2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You will be transferred to the Delete Page.");
            goToDelete();     
        }

        private void goToDelete()
        {
            DeleteRestaurant deleteRestaurant = new DeleteRestaurant();
            deleteRestaurant.Show();
        }
    }
}

﻿using System;
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
    /// Interaktionslogik für OrderHistory.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OrderHistory orderHistory = new OrderHistory();
            orderHistory.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            PlaceNewOrder placeNewOrder = new PlaceNewOrder();
            placeNewOrder.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            deleteOrder.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}

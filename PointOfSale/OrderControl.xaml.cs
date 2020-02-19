using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        List<string> orderList = new List<string>();

        public OrderControl()
        {
            InitializeComponent();

            //AddCowPokeChili.Click += AddCowPokeChili_Click();

            ListBox.ItemsSource = orderList;
        }

        private void AddCowPokeChili_Click(object sender, RoutedEventArgs e)
        {
            orderList.Add("BIG CHUNGUS");
            ListBox.ItemsSource = orderList;
            Console.WriteLine("Big Chungus");
        }

        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

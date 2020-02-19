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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        public OrderControl()
        {
            InitializeComponent();

            AddCowPokeChili.Click += AddCowPokeChili_Click;
            AddRustlerRibs.Click += AddRustlerRibs_Click;
            AddPecosPulledPork.Click += AddPecosPulledPork_Click;
            AddTrailBurger.Click += AddTrailBurger_Click;
            AddDakotaDoubleBurger.Click += AddDakotaDoubleBurger_Click;
            AddTexasTripleBurger.Click += AddTexasTripleBurger_Click;
            AddAngryChicken.Click += AddAngryChicken_Click;

            AddChiliCheeseFries.Click += AddChiliCheeseFries_Click;
            AddCornDodgers.Click += AddCornDodgers_Click;
            AddPanDeCampo.Click += AddPanDeCampo_Click;
            AddBakedBeans.Click += AddBakedBeans_Click;

            AddJerkedSoda.Click += AddJerkedSoda_Click;
            AddTexasTea.Click += AddTexasTea_Click;
            AddCowboyCoffee.Click += AddCowboyCoffee_Click;
            AddWater.Click += AddWater_Click;
            
        }

        private void AddCowPokeChili_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new CowpokeChili());
        }

        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new RustlersRibs());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new PecosPulledPork());
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new TrailBurger());
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new TexasTripleBurger());
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new AngryChicken());
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new ChiliCheeseFries());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new CornDodgers());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new PanDeCampo());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new BakedBeans());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new JerkedSoda());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new TexasTea());
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new CowboyCoffee());
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(new Water());
        }
    }
}

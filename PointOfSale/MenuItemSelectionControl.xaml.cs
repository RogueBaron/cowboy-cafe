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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
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

        /// <summary>
        /// An event handler to add Cow Poke Chili to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowPokeChili_Click(object sender, RoutedEventArgs e)
        {
            //ListBox.Items.Add(new CowpokeChili());

            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new CowpokeChili());
                    }

                }
            }

        }

        /// <summary>
        /// An event handler to add Rustler's Ribs to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new RustlersRibs());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Pecos Pulled Pork to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new PecosPulledPork());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Trail Burger to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new TrailBurger());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Double Burger to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new DakotaDoubleBurger());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Texas Triple Burger to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new TexasTripleBurger());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Angry Chicken to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new AngryChicken());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Chili Cheese Fries to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new ChiliCheeseFries());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Corn Dodgers to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new CornDodgers());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Pan De Campo to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new PanDeCampo());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Baked Beans to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new BakedBeans());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Jerked Soda to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new JerkedSoda());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Texas Tea to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new TexasTea());
                    }

                }
            }
        }

        /// <summary>
        /// An event handler to add Cowboy Coffee to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new CowboyCoffee());
                    }
                }
            }
        }

        /// <summary>
        /// An event handler to add Water to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order)
            {
                if (DataContext is Order data)
                {
                    if (sender is Button button)
                    {
                        data.Add(new Water());
                    }

                }
            }
        }
    }
}

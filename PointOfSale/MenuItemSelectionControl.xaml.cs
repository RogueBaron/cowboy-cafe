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
using CowboyCafe.Extensions;

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
            

            AddCowPokeChili.Click += AddItem;
            AddRustlerRibs.Click += AddItem;
            AddPecosPulledPork.Click += AddItem;
            AddTrailBurger.Click += AddItem;
            AddDakotaDoubleBurger.Click += AddItem;
            AddTexasTripleBurger.Click += AddItem;
            AddAngryChicken.Click += AddItem;

            AddChiliCheeseFries.Click += AddItem;
            AddCornDodgers.Click += AddItem;
            AddPanDeCampo.Click += AddItem;
            AddBakedBeans.Click += AddItem;

            AddJerkedSoda.Click += AddItem;
            AddTexasTea.Click += AddItem;
            AddCowboyCoffee.Click += AddItem;
            AddWater.Click += AddItem;
        }

        /// <summary>
        /// An event handler to add Cow Poke Chili to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItem(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();
            //ListBox.Items.Add(new CowpokeChili());
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch(button.Tag)
                    {
                        case "cowPokeChili":
                            var entree = new CowpokeChili();
                            var screen = new CustomizeItemControl();
                            order.Add(entree);
                            orderControl.swapScreen(screen);
                            break;
                        case "rustlersRibs":
                            order.Add(new RustlersRibs());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "pecosPulledPork":
                            order.Add(new PecosPulledPork());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "trailBurger":
                            order.Add(new TrailBurger());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "dakotaDoubleBurger":
                            order.Add(new DakotaDoubleBurger());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "texasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "angryChicken":
                            order.Add(new AngryChicken());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "chiliCheeseFries":
                            order.Add(new ChiliCheeseFries());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "cornDodgers":
                            order.Add(new CornDodgers());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "panDeCampo":
                            order.Add(new PanDeCampo());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "bakedBeans":
                            order.Add(new BakedBeans());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "jerkedSoda":
                            order.Add(new JerkedSoda());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "texasTea":
                            order.Add(new TexasTea());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "cowboyCoffee":
                            order.Add(new CowboyCoffee());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                        case "water":
                            order.Add(new Water());
                            orderControl.swapScreen(new CustomizeItemControl());
                            break;
                    }
                }
            }
        }
    }
}

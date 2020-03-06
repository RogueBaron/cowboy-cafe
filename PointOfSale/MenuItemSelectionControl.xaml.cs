﻿using System;
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
            var screen = new CustomizeItemControl();
            //ListBox.Items.Add(new CowpokeChili());
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch(button.Tag)
                    {
                        case "cowPokeChili":
                            var cowpokeChili = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(cowpokeChili, screen);
                            break;
                        case "rustlersRibs":
                            var rustlersRibs = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(rustlersRibs, screen);
                            break;
                        case "pecosPulledPork":
                            var pecosPulledPork = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(pecosPulledPork, screen);
                            break;
                        case "trailBurger":
                            var trailBurger = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(trailBurger, screen);
                            break;
                        case "dakotaDoubleBurger":
                            var dakotaDoubleBurger = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(dakotaDoubleBurger, screen);
                            break;
                        case "texasTripleBurger":
                            var texasTripleBurger = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(texasTripleBurger, screen);
                            break;
                        case "angryChicken":
                            var angryChicken = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(angryChicken, screen);
                            break;
                        case "chiliCheeseFries":
                            var chiliCheeseFires = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(chiliCheeseFires, screen);
                            break;
                        case "cornDodgers":
                            var cornDodgers = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(cornDodgers, screen);
                            break;
                        case "panDeCampo":
                            var panDeCamp = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(panDeCamp, screen);
                            break;
                        case "bakedBeans":
                            var bakedBeans = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(bakedBeans, screen);
                            break;
                        case "jerkedSoda":
                            var jerkedSoda = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(jerkedSoda, screen);
                            break;
                        case "texasTea":
                            var texasTea = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(texasTea, screen);
                            break;
                        case "cowboyCoffee":
                            var cowboyCoffee = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(cowboyCoffee, screen);
                            break;
                        case "water":
                            var water = new CowpokeChili();
                            AddItemAndOpenCustomizationScreen(water, screen);
                            break;
                    }
                }
            }
        }

        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext Expected");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancerstor of order controll was null");

                screen.DataContext = item;
                orderControl.swapScreen(screen);
            }

            order.Add(item);
        }
    }
}

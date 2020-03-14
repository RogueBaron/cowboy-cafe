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
    /// Interaction logic for CustomizeItemControl.xaml
    /// </summary>
    public partial class CustomizeItemControl : UserControl
    {
        public CustomizeItemControl()
        {
            InitializeComponent();

            SmallSide.Click += SetSizeSide;
            MediumSide.Click += SetSizeSide;
            LargeSide.Click += SetSizeSide;

            SmallDrink.Click += SetSizeDrink;
            MediumDrink.Click += SetSizeDrink;
            LargeDrink.Click += SetSizeDrink;

            CreamSoda.Click += SetFlavorDrink;
            OrangeSoda.Click += SetFlavorDrink;
            Sarsparilla.Click += SetFlavorDrink;
            BirchBeer.Click += SetFlavorDrink;
            RootBeer.Click += SetFlavorDrink;


            //disbaleAllButtons();
        }


        private void SetSizeSide(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side side)
            {
                    if (sender is RadioButton radio)
                    {
                        switch (radio.Name)
                        {
                            case "SmallSide":
                                side.Size = CowboyCafe.Data.Size.Small;
                                break;
                            case "MediumSide":
                                side.Size = CowboyCafe.Data.Size.Medium;
                                break;
                            case "LargeSide":
                                side.Size = CowboyCafe.Data.Size.Large;
                                break;
                        }
                }
            }
        }


        private void SetSizeDrink(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink drink)
            {
                if (sender is RadioButton radio)
                {
                    switch (radio.Name)
                    {
                        case "SmallDrink":
                            drink.Size = CowboyCafe.Data.Size.Small;
                            break;
                        case "MediumDrink":
                            drink.Size = CowboyCafe.Data.Size.Medium;
                            break;
                        case "LargeDrink":
                            drink.Size = CowboyCafe.Data.Size.Large;
                            break;
                    }
                }
            }
        }

        private void SetFlavorDrink(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda drink)
            {
                if (sender is RadioButton radio)
                {
                    switch (radio.Name)
                    {
                        case "BirchBeer":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
                            break;
                        case "CreamSoda":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
                            break;
                        case "OrangeSoda":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
                            break;
                        case "RootBeer":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
                            break;
                        case "Sarsparilla":
                            drink.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
                            break;
                    }
                }
            }
        }


        private void disbaleAllButtons()
        {
            Bread.IsEnabled = false;
            Pickle.IsEnabled = false;
            Ice.IsEnabled = false;
            RoomForCream.IsEnabled = false;
            Decaf.IsEnabled = false;
            Cheese.IsEnabled = false;
            SourCream.IsEnabled = false;
            GreenOnions.IsEnabled = false;
            TortillaStrips.IsEnabled = false;
            Tomato.IsEnabled = false;
            Lettuce.IsEnabled = false;
            Mayo.IsEnabled = false;
            Ketchup.IsEnabled = false;
            Mustard.IsEnabled = false;
            Bun.IsEnabled = false;
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = false;
            Bacon.IsEnabled = false;
            Egg.IsEnabled = false;

            SmallSide.IsEnabled = false;
            MediumSide.IsEnabled = false;
            LargeSide.IsEnabled = false;

            SmallDrink.IsEnabled = false;
            MediumDrink.IsEnabled = false;
            LargeDrink.IsEnabled = false;

            CreamSoda.IsEnabled = false;
            OrangeSoda.IsEnabled = false;
            Sarsparilla.IsEnabled = false;
            BirchBeer.IsEnabled = false;
            RootBeer.IsEnabled = false;
        }
    }
}

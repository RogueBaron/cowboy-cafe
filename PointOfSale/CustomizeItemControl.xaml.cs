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


            //disbaleAllButtons();
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

            Small.IsEnabled = false;
            Medium.IsEnabled = false;
            Large.IsEnabled = false;

            CreamSoda.IsEnabled = false;
            OrangeSoda.IsEnabled = false;
            Sarsparilla.IsEnabled = false;
            BirchBeer.IsEnabled = false;
            RootBeer.IsEnabled = false;
        }
    }
}

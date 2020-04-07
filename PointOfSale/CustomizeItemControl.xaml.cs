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
    /// Interaction logic for CustomizeItemControl.xaml
    /// </summary>
    public partial class CustomizeItemControl : UserControl
    {
        public CustomizeItemControl()
        {
            InitializeComponent();

            //configureAllButtons();

        }

        private void addSize_Click(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();

            if(ancestor is OrderControl)
            {
                ancestor.changeEnumSize();
            }
        }

        private void addFlavor_Click(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();

            if (ancestor is OrderControl)
            {
                ancestor.changeEnumFlavor();
            }
        }

        private void configureAllButtons()
        {
            
            Bread.Visibility =  Visibility.Hidden;
            Pickle.Visibility = Visibility.Hidden;
            Ice.Visibility = Visibility.Hidden;
            RoomForCream.Visibility = Visibility.Hidden;
            Decaf.Visibility = Visibility.Hidden;
            Cheese.Visibility = Visibility.Hidden;
            SourCream.Visibility = Visibility.Hidden;
            GreenOnions.Visibility = Visibility.Hidden;
            TortillaStrips.Visibility = Visibility.Hidden;
            Tomato.Visibility = Visibility.Hidden;
            Lettuce.Visibility = Visibility.Hidden;
            Mayo.Visibility = Visibility.Hidden;
            Ketchup.Visibility = Visibility.Hidden;
            Mustard.Visibility = Visibility.Hidden;
            Bun.Visibility = Visibility.Hidden;
            Sweet.Visibility = Visibility.Hidden;
            Lemon.Visibility = Visibility.Hidden;
            Bacon.Visibility = Visibility.Hidden;
            Egg.Visibility = Visibility.Hidden;

            SizeBox.Visibility = Visibility.Hidden;
            FlavorBox.Visibility = Visibility.Hidden;

            if(DataContext is IOrderItem item)
            {

                if (item is AngryChicken)
                {
                    Bread.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                }

                if (item is Side s)
                {
                    SizeBox.Visibility = Visibility.Visible;
                }

                if (item is CowboyCoffee cc)
                {
                    Ice.Visibility = Visibility.Visible;
                    RoomForCream.Visibility = Visibility.Visible;
                    Decaf.Visibility = Visibility.Visible;
                    SizeBox.Visibility = Visibility.Visible;
                }

                if (item is CowpokeChili cpc)
                {
                    Cheese.Visibility = Visibility.Hidden;
                    SourCream.Visibility = Visibility.Hidden;
                    GreenOnions.Visibility = Visibility.Hidden;
                    TortillaStrips.Visibility = Visibility.Hidden;
                }

                if (item is DakotaDoubleBurger ddb)
                {
                    Tomato.Visibility = Visibility.Visible;
                    Lettuce.Visibility = Visibility.Visible;
                    Mayo.Visibility = Visibility.Visible;
                    Ketchup.Visibility = Visibility.Visible;
                    Mustard.Visibility = Visibility.Visible;
                    Bun.Visibility = Visibility.Visible;
                    Cheese.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                }

                if (item is JerkedSoda js)
                {
                    SizeBox.Visibility = Visibility.Visible;
                    FlavorBox.Visibility = Visibility.Visible;
                    Ice.Visibility = Visibility.Hidden;
                }

                if (item is PecosPulledPork ppp)
                {
                    Bread.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                }

                if (item is TexasTea tt)
                {
                    Ice.Visibility = Visibility.Visible;
                    Sweet.Visibility = Visibility.Visible;
                    Lemon.Visibility = Visibility.Visible;
                    SizeBox.Visibility = Visibility.Visible;
                }

                if (item is TexasTripleBurger ttb)
                {
                    Bacon.Visibility = Visibility.Visible;
                    Egg.Visibility = Visibility.Visible;
                    Tomato.Visibility = Visibility.Visible;
                    Lettuce.Visibility = Visibility.Visible;
                    Mayo.Visibility = Visibility.Visible;
                    Ketchup.Visibility = Visibility.Visible;
                    Mustard.Visibility = Visibility.Visible;
                    Bun.Visibility = Visibility.Visible;
                    Cheese.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                }

                if (item is TrailBurger tb)
                {
                    Ketchup.Visibility = Visibility.Visible;
                    Mustard.Visibility = Visibility.Visible;
                    Bun.Visibility = Visibility.Visible;
                    Cheese.Visibility = Visibility.Visible;
                    Pickle.Visibility = Visibility.Visible;
                }

                if (item is Water w)
                {
                    Ice.Visibility = Visibility.Visible;
                    Lemon.Visibility = Visibility.Visible;
                    SizeBox.Visibility = Visibility.Visible;
                }
            }
        }
    }
}

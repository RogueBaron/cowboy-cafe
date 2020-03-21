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

        /// <summary>
        /// initalizer for Order Control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            DataContext = new Order();
            
        }

        public void changeEnumSize()
        {
            if(DataContext is Order order)
            {
                order.changeEnumSize();
            }
        }

        public void changeEnumFlavor()
        {
            if (DataContext is Order order)
            {
                order.changeEnumFlavor();
            }
        }

        private void AddItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl(); 
        }

        private void AddCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        private void AddCompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        public void swapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}

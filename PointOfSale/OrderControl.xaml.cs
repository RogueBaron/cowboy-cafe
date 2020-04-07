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

        private void EditSelectedItem(object sender, RoutedEventArgs e)
        {
            
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

            var screen = new TransactionControl();
            screen.DataContext = this.DataContext;
            swapScreen(screen);
        }

        public void swapScreen(UIElement element)
        {

            //Container.Child = element;

            
            if(element is TransactionControl)
            {
                LargeContainer.Child = element;
            }
            else if(element is OrderControl)
            {
                LargeContainer.Child = element;
            }
            else
            {
                Container.Child = element;
            }
            
        }

        public void editScreen(IOrderItem item)
        {
            var screen = new CustomizeItemControl();
            screen.DataContext = item;
            swapScreen(screen);
        }
    }
}

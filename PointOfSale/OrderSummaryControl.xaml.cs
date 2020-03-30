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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {

        public OrderSummaryControl()
        {
            InitializeComponent();
            //DataContext = new Order();
        }

        void deleteItem(object sender, RoutedEventArgs args)
        {
            if(sender is Button b)
            {
                var item = (IOrderItem) b.DataContext;
                
                if(DataContext is Order order)
                {
                    order.Remove(item);
                }
            }
        }

        void swapSelection(object sender, SelectionChangedEventArgs args)
        {
           
            var item = ((sender as ListBox).SelectedItem as IOrderItem);
            OrderControl control = this.FindAncestor<OrderControl>();
            if (item is IOrderItem)
            {
                if (control is OrderControl)
                {
                    control.editScreen(item);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

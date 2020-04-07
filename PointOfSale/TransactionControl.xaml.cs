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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
       

        public TransactionControl()
        {
            InitializeComponent();

        }

        private void AddCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            //newOrder();
            returnToOrder();
        }

        private void AddPayWithCard(object sender, RoutedEventArgs e)
        {
            var card = new CashRegister.CardTerminal();

            if(DataContext is Order order)
            {
                switch (card.ProcessTransaction(order.Total)){
                    case CashRegister.ResultCode.Success:
                        printRecepit(0);
                        newOrder();
                        break;
                    case CashRegister.ResultCode.CancelledCard:
                        MessageBox.Show("Error: Cancelled Card");
                        returnToOrder();
                        break;
                    case CashRegister.ResultCode.InsufficentFunds:
                        MessageBox.Show("Error: Insufficent Funds");
                        returnToOrder();
                        break;
                    case CashRegister.ResultCode.ReadError:
                        MessageBox.Show("Error: Read Error");
                        returnToOrder();
                        break;
                    case CashRegister.ResultCode.UnknownErrror:
                        MessageBox.Show("Error: Unknown Error");
                        returnToOrder();
                        break;
                }
            }
            
        }

        private void AddPayWithCash(object sender, RoutedEventArgs e)
        {
            var cash = new CashRegister.CashDrawer();
            //this has to be put somewhere else?
        }

        private void newOrder()
        {
            var order = new Order();
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new OrderControl();
            screen.DataContext = order;
            orderControl.swapScreen(screen);
        }

        private void returnToOrder()
        {
            var orderControl = this.FindAncestor<OrderControl>();
            

            
        }

        private void printRecepit(int cardOrCash) //0 for card, 1 for cash
        {
            if(DataContext is Order order)
            {
                var printer = new CashRegister.ReceiptPrinter();
                printer.Print("Order #" + order.OrderNumber.ToString() + "\n");
                printer.Print("Date: " + DateTime.Now.ToString("h:mm:ss tt") + "\n");

                foreach(IOrderItem item in order.Items)
                {
                    //printer.Print("\n");
                    printer.Print(item.ToString() + " - " + string.Format("{0:C}", item.Price) + "\n");

                    foreach(string s in item.SpecialInstructions)
                    {
                        printer.Print("-"+ s + "\n");
                    }
                }

                printer.Print("\n");
                printer.Print("Subtotal: " + string.Format("{0:C}", order.Subtotal) + "\n");
                printer.Print("Total: " + string.Format("{0:C}", order.Total) + "\n");
                if (cardOrCash == 0)
                {
                    printer.Print("Transaction made with credit \n");
                }
                else
                {
                    printer.Print("Transaction made with cash\n");
                    //add total paid with and change returned
                }

                printer.Print("\n");

            }
        }

    }
}

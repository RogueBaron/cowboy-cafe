using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// number of the previous order
        /// </summary>
        private uint LastOrderNumber = 0;

        /// <summary>
        /// list of items currently in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// IEnumerable to iterate though items in the list.
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// subtotal of the current order
        /// </summary>
        public double Subtotal { get
            {
                double count = 0;
                foreach(IOrderItem i in Items)
                {
                    count += i.Price;
                }
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                return count;
            }
        }

        /// <summary>
        /// the number associated with the current order (1+lastOrderNumber)
        /// </summary>
        public uint OrderNumber { get { return LastOrderNumber++; } }

        /// <summary>
        /// An event to fire whenever an item is added, removed or the subtotal changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            LastOrderNumber++;
        }
        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            //if (item is INotifyPropertyChanged notifier)
            //{
            //    notifier.PropertyChanged += OnItemPropertyChange;
            //}

        }

        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            //if (item is INotifyPropertyChanged notifier)
            //{
            //    notifier.PropertyChanged -= OnItemPropertyChange;
            //}
        }

        private void OnItemPropertyChange(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}

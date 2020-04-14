using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink: INotifyPropertyChanged, IOrderItem
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { 
            get { return size; } 
            set { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            } 
        }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Wether the drink has ice or not.
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets the special Instructions of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        
    }
}


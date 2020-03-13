using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an Entree
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {

        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special Instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}

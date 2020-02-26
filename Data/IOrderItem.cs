using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The specal instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

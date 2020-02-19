using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Baked Beans Side Class
    /// </summary>
    public class BakedBeans: Side
    {
        /// <summary>
        /// Baked Beans price based off size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Baked Beans calories based off size 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// prints out name of item
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Baked Beans";
                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Large:
                    return "Large Baked Beans";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

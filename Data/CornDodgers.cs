using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Corn Dodgers Side Class
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// Corn Dodgers price based off size
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
        /// Corn Dodgers calories based off size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
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
                    return "Small Corn Dodgers";
                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Large:
                    return "Large Corn Dodgers";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

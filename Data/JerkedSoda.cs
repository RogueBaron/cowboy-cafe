using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class repreesenting jerked soda
    /// </summary>
    public class JerkedSoda : Drink, IOrderItem
    {
        /// <summary>
        /// if the soda has ice or not
        /// </summary>
        public override bool Ice { get; set; } = true;

        /// <summary>
        /// what flavor the soda is
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// price of the soda
        /// </summary>
        public override double Price {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// special instructions for the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("hold ice");

                return instructions;
            }
        }

        /// <summary>
        /// prints out name of item
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            switch (Size)
            {
                case Size.Small:
                    sb.Append("Small ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Large:
                    sb.Append("Large ");
                    break;
                default:
                    throw new NotImplementedException();
            }

            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    sb.Append("Birch Beer ");
                    break;
                case SodaFlavor.CreamSoda:
                    sb.Append("Cream Soda ");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append("Orange Soda ");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append("Root Beer ");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append("Sarsparilla ");
                    break;
                default:
                    throw new NotImplementedException();
            }

            sb.Append("Jerked Soda");

            return sb.ToString();
        }
    }
}

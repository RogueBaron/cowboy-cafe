using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a cowboy coffee
    /// </summary>
    public class CowboyCoffee: Drink, IOrderItem, INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        private bool ice = false;

        /// <summary>
        /// if the coffee has ice or no
        /// </summary>
        public override bool Ice {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool roomForCream = false;

        /// <summary>
        /// if the coffee has room for cream or not
        /// </summary>
        public bool RoomForCream { get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool decaf = false;

        /// <summary>
        /// if the coffee is decaf or not
        /// </summary>
        public bool Decaf { 
            get { return decaf; } 
            set {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("add ice");
                if (RoomForCream) instructions.Add("room for cream");
                if (Decaf) instructions.Add("decaf coffee");

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

            if (Decaf)
            {
                sb.Append("Decaf ");
            }

            sb.Append("Cowboy Coffee");

            return sb.ToString();
        }
    }
}

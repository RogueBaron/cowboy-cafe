using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing a water
    /// </summary>
    public class Water : Drink, IOrderItem, INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        private bool ice = true;

        /// <summary>
        /// if the water has ice or not
        /// </summary>
        public override bool Ice { 
            get { return ice; } 
            set { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;

        /// <summary>
        /// if the water has a lemon or not
        /// </summary>
        public bool Lemon { 
            get { return lemon; } 
            set { 
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("hold ice");
                if (Lemon) instructions.Add("add lemon");

                return instructions;
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
                case (Size.Small):
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

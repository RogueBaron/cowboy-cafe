﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing texas tea
    /// </summary>
    public class TexasTea : Drink, IOrderItem, INotifyPropertyChanged
    {
        public override event PropertyChangedEventHandler PropertyChanged;

        private bool ice = true;

        /// <summary>
        /// if the tea has ice or not
        /// </summary>
        public override bool Ice { 
            get { return ice; } 
            set { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        private bool sweet = true;

        /// <summary>
        /// if the tea is sweet or not
        /// </summary>
        public bool Sweet { 
            get { return sweet; } 
            set { 
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;

        /// <summary>
        /// if the tea has a lemonn or not
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
        /// price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// calories of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// special instructions of the tea
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
            StringBuilder sb = new StringBuilder();

            switch (Size)
            {
                case (Size.Small):
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

            sb.Append("Texas ");

            if (Sweet)
            {
                sb.Append("Sweet ");
            }
            else
            {
                sb.Append("Plain ");
            }

            sb.Append("Tea");
            return sb.ToString();
        }
    }
}

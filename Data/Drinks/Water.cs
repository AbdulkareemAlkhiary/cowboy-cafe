/* Author: Abdulkareem Alkhiary
 * Class: Water.cs 
 * Description: Handles the Water */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Water
    /// </summary>
    public class Water : Drink
    {

        private bool lemon = false;
        /// <summary>
        /// Sets true if the drink needs lemons
        /// </summary>
        public bool Lemon { get { return lemon; } set { lemon = value;
                NotifyOfPropertyChange("Lemon");
                NotifyOfPropertyChange("SpecialInstructions");
            } }

        /// <summary>
        /// The price of the Water
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
        /// The calories of the Water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
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

        private bool ice = true;
        /// <summary>
        /// If the Water is served with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value;
                NotifyOfPropertyChange("Ice");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// ToString method to return readlable name
        /// </summary>
        public override string ToString()
        {
            return Size + " Water";
        }

        private List<string> ingredients;
        /// <summary>
        /// Water Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
    }
}


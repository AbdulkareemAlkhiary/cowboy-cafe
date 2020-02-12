/* Author: Abdulkareem Alkhiary
 * Class: CowboyCoffee.cs 
 * Description: Handles the Cowboy Coffee */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {

        /// <summary>
        /// Sets true if the drink needs room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// The price of the Cowboy Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;
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
        /// The calories of the Cowboy Coffee
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

        private bool ice = false;
        /// <summary>
        /// If the Cowboy Coffee is served with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Leave room for cream");

                return instructions;
            }
        }
    }
}


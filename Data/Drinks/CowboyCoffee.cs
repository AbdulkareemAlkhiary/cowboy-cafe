﻿/* Author: Abdulkareem Alkhiary
 * Class: CowboyCoffee.cs 
 * Description: Handles the Cowboy Coffee */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {

        private bool roomForCream = false;
        /// <summary>
        /// Sets true if the drink needs room for cream
        /// </summary>
        public bool RoomForCream {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                NotifyOfPropertyChange("RoomForCream");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Sets true if the coffee is decaf
        /// </summary>
        public bool Decaf {
            get { return decaf; }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Decaf");
            }
        }

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
        /// If the Water is served with ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// ToString method to return readlable name
        /// </summary>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Cowboy Coffee";
            }
            
            return Size + " Cowboy Coffee";
        }

        private List<string> ingredients;
        /// <summary>
        /// Cowboy Coffee Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
    }
}


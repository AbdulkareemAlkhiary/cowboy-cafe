﻿/* Author: Abdulkareem Alkhiary
 * Class: JerkedSoda.cs 
 * Description: Handles the Jerked Soda */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda
    /// </summary>
    public class JerkedSoda : Drink
    {

        /// <summary>
        /// Gets/Sets soda flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// The price of the Jerked Soda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// The calories of the Jerked Soda
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

        private bool ice = true;
        /// <summary>
        /// If the Jerked Soda is served with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }



        /// <summary>
        /// Special instructions for the preparation of the Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold ice");

                return instructions;
            }
        }
    }
}


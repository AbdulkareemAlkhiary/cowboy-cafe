/* Author: Abdulkareem Alkhiary
 * Class: JerkedSoda.cs 
 * Description: Handles the Jerked Soda */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda
    /// </summary>
    public class JerkedSoda : Drink
    {

        private SodaFlavor flavor;
        /// <summary>
        /// Gets/Sets soda flavor
        /// </summary>
        public SodaFlavor Flavor {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Flavor");
            }
        }


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
        /// Special instructions for the preparation of the Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// ToString method to return readlable name
        /// </summary>
        public override string ToString()
        {

            if (Flavor == SodaFlavor.BirchBeer)
            {
                return Size + " Birch Beer Jerked Soda";
            }
            else if (Flavor == SodaFlavor.CreamSoda)
            {
                return Size + " Cream Soda Jerked Soda";
            }
            else if (Flavor == SodaFlavor.OrangeSoda)
            {
                return Size + " Orange Soda Jerked Soda";
            }
            else if (Flavor == SodaFlavor.RootBeer)
            {
                return Size + " Root Beer Jerked Soda";
            }
            else
            {
                return Size + " Sarsparilla Jerked Soda";

            }
        }

        private List<string> ingredients;
        /// <summary>
        /// Jerked Soda Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
    }
}


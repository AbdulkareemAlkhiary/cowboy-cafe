/* Author: Abdulkareem Alkhiary
 * Class: PanDeCampo.cs 
 * Description: Handles the Jerked Soda */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda
    /// </summary>
    public class JerkedSoda : Side
    {

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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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


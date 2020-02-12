/* Author: Abdulkareem Alkhiary
 * Class: TexasTea.cs 
 * Description: Handles the Texas Tea */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea
    /// </summary>
    public class TexasTea : Drink
    {

        /// <summary>
        /// Sets true if the drink needs to be sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Sets true if the drink needs lemons
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The price of the Texas Tea
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
        /// The calories of the Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (Sweet) { return 5; }
                        return 10;
                    case Size.Medium:
                        if (Sweet) { return 11; }
                        return 22;
                    case Size.Large:
                        if (Sweet) { return 18; }
                        return 36;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the Texas Teaa is served with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the Texas Tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}


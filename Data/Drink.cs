/* Author: Abdulkareem Alkhiary
 * Class: Drink.cs 
 * Description: Handles drnik properties */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the ingredients of the drink
        /// </summary>
        public abstract List<string> Ingredients { get; }


        /// <summary>
        /// Sets true if the drink contains ice
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Special instructions for the preparation of the Sodas
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}

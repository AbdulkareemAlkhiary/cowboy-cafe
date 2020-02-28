/* Author: Abdulkareem Alkhiary
 * Class: Entree.cs 
 * Description: Handles the Entree properties */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {

        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the preparation of the Entrees
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}


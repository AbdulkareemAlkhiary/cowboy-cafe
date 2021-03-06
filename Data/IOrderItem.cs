﻿/* Author: Abdulkareem Alkhiary
 * Class: IOrderItem.cs 
 * Description: Handles the items */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        public List<string> SpecialInstructions { get; }

        /// <summary>
        /// The calories for this order item
        /// </summary>
        public uint Calories { get; }
    }
}

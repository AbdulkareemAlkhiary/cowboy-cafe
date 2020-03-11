/* Author: Abdulkareem Alkhiary
 * Class: Drink.cs 
 * Description: Handles drnik properties */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
            }
        }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// If the Water is served with ice
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Special instructions for the preparation of the Sodas
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Ingredients of the drink
        /// </summary>
        public abstract List<string> Ingredients { get; set; }

        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}

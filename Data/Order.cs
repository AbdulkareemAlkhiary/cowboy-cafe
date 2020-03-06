﻿/* Author: Abdulkareem Alkhiary
 * Class: Order.cs 
 * Description: Handles the order for application */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        static private uint lastOrderNumber = 1;

        /// <summary>
        /// Makes a list
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// item list to enumerable
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Calculates subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double totalCost = 0;
                foreach(IOrderItem item in items)
                {
                    totalCost += item.Price;
                }
                return totalCost;
            }
            set
            {
                ///
            }
        }

        /// <summary>
        /// Gets last order number
        /// </summary>
        public uint OrderNumber => lastOrderNumber++;


        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// add item
        /// </summary>
        /// <param name="item">item added</param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier) 
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
        }

        /// <summary>
        /// removes item
        /// </summary>
        /// <param name="item">item removed</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}

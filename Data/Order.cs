/* Author: Abdulkareem Alkhiary
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

        static private uint lastOrderNumber = 0;

        /// <summary>
        /// Order
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
            lastOrderNumber++;
        }


        /// <summary>
        /// Makes a list
        /// </summary>
        private List<IOrderItem> items;

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
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        /// <summary>
        /// removes item
        /// </summary>
        /// <param name="item">item removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
    }
}

/* Author: Abdulkareem Alkhiary
 * Class: Order.cs 
 * Description: Handles the order */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        private uint lastOrderNumber;

        private List<IOrderItem> items;

        public IEnumerable<IOrderItem> Items { get; }

        public double Subtotal { get; }

        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
    }
}

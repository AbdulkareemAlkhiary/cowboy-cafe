/* Author: Abdulkareem Alkhiary
 * Class: OrderNow.cs 
 * Description: Handles current order */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Holds all the data for an order transaction
    /// </summary>
    public class OrderNow
    {

        public Order Order { get; private set; }

        public const double TaxRate = 0.16;

        /// <summary>
        /// Calculate the cost 
        /// </summary>
        public double AddedTax
        {
            get { return Math.Round(Order.Subtotal * TaxRate, 2); }
        }

        /// <summary>
        /// Calculate the total with tax
        /// </summary>
        public double Total
        {
            get { return Order.Subtotal + AddedTax; }
        }

        /// <summary>
        /// Type of payment
        /// </summary>
        public TypeOfPayment payment { get; set; }

        double amountPaid;
        /// <summary>
        /// amount paid
        /// </summary>
        public double AmountPaid
        {
            get { return amountPaid; }
            set
            {
                if (value < Total) return;
                amountPaid = value;
            }
        }

        /// <summary>
        /// Initialize the transaction object
        /// </summary>
        /// <param name="order">The order to hold</param>
        public OrderNow(Order order)
        {
            Order = order;
        }
    }
}
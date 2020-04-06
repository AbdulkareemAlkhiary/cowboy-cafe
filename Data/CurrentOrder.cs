using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Holds all the data for an order transaction
    /// </summary>
    public class CurrentOrder
    {
        /// <summary>
        /// The actual over held in this transaction
        /// </summary>
        public Order Order { get; private set; }

        public const double TaxRate = 0.16;

        /// <summary>
        /// Calculate the cost added due to tax
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
        /// The method used to pay this transaction
        /// </summary>
        public TypeOfPayment payment { get; set; }

        double amountPaid;
        /// <summary>
        /// The amount that the customer paid
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
        public CurrentOrder(Order order)
        {
            Order = order;
        }
    }
}
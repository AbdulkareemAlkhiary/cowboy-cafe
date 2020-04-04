/* Author: Abdulkareem Alkhiary
 * Class: Transaction.cs 
 * Description: Handles the transactions */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Transaction
    {

        /// <summary>
        /// Current Order
        /// </summary>
        public Order Order { get; private set; }

        /// <summary>
        /// Setting order equal to the order construtor
        /// </summary>
        /// <param name="order"></param>
        public Transaction(Order order) 
        {
            Order = order;   
        }

        /// <summary>
        /// Tax rate
        /// </summary>
        public const double TaxAmount = 0.16;

        public double OrderTotal 
        {
            get { return Order.Subtotal + Tax; }
        }

        /// <summary>
        /// Calculates tax amount of order
        /// </summary>
        public double Tax 
        {
            get
            {
                var taxes = Order.Subtotal * TaxAmount;
                taxes = Math.Round(taxes, 2);
                return taxes;
            }
        }

        /// <summary>
        /// Payment of the order
        /// </summary>
        private double payment;
        public double Payment
        {
            get { return payment; }
            set 
            {
                if (OrderTotal > value) { return; }
                    payment = value;
            }
        }
        
    }
}

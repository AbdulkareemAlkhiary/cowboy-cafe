/* Author: Abdulkareem Alkhiary
 * Class: TransactionControl.xaml.cs 
 * Description: Handles the transactions */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using PointOfSale;
using CowboyCafe.Data;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl control;

        // The data for this transaction. The order
        public CurrentOrder currentOrder { get; private set; }

        // For screen switching
        MainWindow Window;

        /// <summary>
        /// Initialize the TransactionControl
        /// </summary>
        /// <param name="order">The transaction control that order links to</param>
        public TransactionControl(Order order)
        {
            InitializeComponent();
            control = this;
            currentOrder = new CurrentOrder(order);
            DataContext = currentOrder;
        }

        /// <summary>
        /// Handles Cash payments when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashPayment_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.payment = TypeOfPayment.Cash;
            Window = this.FindAncestor<MainWindow>();
            FrameworkElement screen = new CashControl(currentOrder.Total, control);
            Window.SwapScreen(screen);
        }

        /// <summary>
        /// Handles credit card payment when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditPayment_Click(object sender, RoutedEventArgs e)
        {
            CardTerminal cardTerminal = new CardTerminal();
            currentOrder.payment = TypeOfPayment.Credit;
            currentOrder.AmountPaid = currentOrder.Total;
            ResultCode code = cardTerminal.ProcessTransaction(currentOrder.Total);

            switch (code)
            {
                case ResultCode.Success:
                    MessageBox.Show("Success: Card Accepted. Printing Receipt");
                    FinishCurrentTransaction();
                    break;
                case ResultCode.CancelledCard:
                    MessageBox.Show("Error: Cancelled Card");
                    break;
                case ResultCode.InsufficentFunds:
                    MessageBox.Show("Error: Insufficent Funds");
                    break;
                case ResultCode.ReadError:
                    MessageBox.Show("Error: Read Error");
                    break;
                case ResultCode.UnknownErrror:
                    MessageBox.Show("Error: Unknown Error");
                    break;
            }
        }

        /// <summary>
        /// Handles order wpf when cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelTransaction_Click(object sender, RoutedEventArgs e)
        {
            OrderControl newOrderControl = new OrderControl();
            newOrderControl.CompleteOrderButton.IsEnabled = true;
            newOrderControl.ItemSelectButton.IsEnabled = true;
            Window.SwapScreen(newOrderControl);
        }

        /// <summary>
        /// Finishes the transaction and prints the receipt with all information
        /// </summary>
        public void FinishCurrentTransaction()
        {
            // Print the receipt for the customer
            ReceiptPrinter receiptPrint = new ReceiptPrinter();
            receiptPrint.Print(ReceiptBuilder());

            MessageBox.Show("Transaction Complete, returning for next order");
            OrderControl newOrderControl = new OrderControl();
            Window.SwapScreen(newOrderControl);

            newOrderControl.CompleteOrderButton.IsEnabled = true;
            newOrderControl.ItemSelectButton.IsEnabled = true;
        }

        /// <summary>
        /// Generates a string to print into log file
        /// </summary>
        /// <returns>stringbuilder with all of order details</returns>
        public string ReceiptBuilder()
        {
            StringBuilder receipt = new StringBuilder();
            int printCharacterMax = 60;
            double TaxRate = 0.16;
            uint orderNumber = currentOrder.Order.OrderNumber;
            DateTime dateTime = DateTime.Now;
            double subtotal = currentOrder.Order.Subtotal;
            double total = currentOrder.Total;
            double tax = Math.Round((subtotal * TaxRate), 2);
            TypeOfPayment formOfPayment = currentOrder.payment;
            double amountPaid = currentOrder.AmountPaid;
            double change = currentOrder.AmountPaid - currentOrder.Total;

            receipt.AppendLine("Cowboy Cafe");
            receipt.AppendLine($"Order: {orderNumber}");
            receipt.AppendLine(dateTime.ToString());
            receipt.Append('-', printCharacterMax); receipt.AppendLine();
            receipt.AppendLine("Items:");

            foreach (IOrderItem item in currentOrder.Order.Items)
            {
                string itemName = item.ToString();
                string price = item.Price.ToString("C");
                if (itemName.Length + price.Length + 1 > printCharacterMax)
                {
                    receipt.Append(itemName, 0, printCharacterMax - price.Length - 1);
                    receipt.Append(" ");
                    receipt.Append(price);
                }
                else
                {
                    receipt.Append(itemName);
                    receipt.Append(' ', printCharacterMax - itemName.Length - price.Length);
                    receipt.Append(price);
                }
                receipt.AppendLine();

                if (item.SpecialInstructions != null)
                {
                    foreach (string instruction in item.SpecialInstructions)
                    {
                        receipt.Append(' ', 5);
                        receipt.Append(instruction);
                        receipt.AppendLine();
                    }
                }
            }

            receipt.Append('-', printCharacterMax); receipt.AppendLine();

            receipt.Append(' ', printCharacterMax - 15 - 9);
            receipt.Append("Subtotal:");
            receipt.Append(' ', 15 - subtotal.ToString("C").Length);
            receipt.AppendLine(subtotal.ToString("C"));

            receipt.Append(' ', printCharacterMax - 15 - 4);
            receipt.Append("Tax:");
            receipt.Append(' ', 15 - tax.ToString("C").Length);
            receipt.AppendLine(tax.ToString("C"));

            receipt.Append('-', printCharacterMax); receipt.AppendLine();

            receipt.Append(' ', printCharacterMax - 15 - 6);
            receipt.Append("Total:");
            receipt.Append(' ', 15 - total.ToString("C").Length);
            receipt.AppendLine(total.ToString("C"));

            receipt.Append('-', printCharacterMax); receipt.AppendLine();

            receipt.Append("Payment Type:" + formOfPayment.ToString());

            if (formOfPayment == TypeOfPayment.Credit) receipt.Append(' ', 19 - amountPaid.ToString("C").Length);
            else receipt.Append(' ', 21 - amountPaid.ToString("C").Length);

            receipt.Append("Amount Paid:          " + amountPaid.ToString("C"));
            receipt.AppendLine(); receipt.AppendLine();

            receipt.Append(' ', printCharacterMax - 15 - 8);
            receipt.Append(" Change:");
            receipt.Append(' ', 15 - tax.ToString("C").Length);
            receipt.AppendLine(change.ToString("C"));
            receipt.AppendLine(); receipt.AppendLine(); receipt.AppendLine(); receipt.AppendLine();

            return receipt.ToString();
        }

        /// <summary>
        /// Initializes ancestor variable upon initialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlStart(object sender, RoutedEventArgs e)
        {
            Window = this.FindAncestor<MainWindow>();
        }
    }
}


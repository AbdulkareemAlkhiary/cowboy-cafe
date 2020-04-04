/* Author: Abdulkareem Alkhiary
 * Class: TransactionControl.xaml.cs 
 * Description: Handles the transactions */
using CashRegister;
using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Order order = null;

        public CashDrawer drawer;

        public double amountPaid = 0;

        public string paymentType = "";

        public TransactionControl(CashDrawer drawer)
        {
            InitializeComponent();
            order = this.DataContext as Order;
        }

        // Need ancestor to load customization screen

        private double salesTax = 0.16;

        private double total;
        public double Total
        {
            get { return total; }
            set
            {
                total = order.Subtotal + (salesTax * order.Subtotal);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

            }
        }


        private void CashPayment(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MainCashControl();
            screen.DataContext = drawer;

            orderControl.SwapOrderScreen(screen);


        }

        private void CreditPayment(object sender, RoutedEventArgs e)
        {
            order = (Order)DataContext;
            CardTerminal cardTerminal = new CardTerminal();
            paymentType = TypeOfPayment.Credit.ToString();
            amountPaid = order.TotalTax;
            ResultCode code = cardTerminal.ProcessTransaction(order.TotalTax);

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

        private void CancelTransaction(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MenuItemSelectionControl();
            screen.DataContext = null;

            orderControl.SwapOrderScreen(new OrderControl());
        }

        /// <summary>
        /// Finishes the transaction and prints the receipt with all information
        /// </summary>
        public void FinishCurrentTransaction()
        {
            // Print the receipt for the customer
            ReceiptPrinter receiptPrint = new ReceiptPrinter();
            receiptPrint.Print(ReceiptBuilder());

            var currentOrderInfo = this.FindAncestor<OrderControl>();
            OrderControl newOrderControl = new OrderControl();

            currentOrderInfo.SwapOrderScreen(newOrderControl);
            newOrderControl.CompleteOrderButton.IsEnabled = true;
            newOrderControl.ItemSelectButton.IsEnabled = true;
        }



        /// <summary>
        /// Generates a string to print into log file
        /// </summary>
        /// <returns></returns>
        public string ReceiptBuilder()
        {
            order = (Order)DataContext;
            int printCharacterMax = 60;
            StringBuilder receipt = new StringBuilder();
            double TaxRate = 0.16;

            receipt.AppendLine("Cowboy Cafe");
            receipt.AppendLine($"Order: {order.OrderNumber}");
            receipt.AppendLine(DateTime.Now.ToString());
            receipt.Append('-', printCharacterMax); // Add a horizontal line
            receipt.AppendLine();
            receipt.AppendLine("Items:");

            foreach (IOrderItem item in order.Items)
            {
                string itemName = item.ToString();
                string price = item.Price.ToString("C"); // Format as currency
                if (itemName.Length + price.Length + 1 > printCharacterMax)
                { // Truncate item name if too long
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

            receipt.Append('-', printCharacterMax);
            receipt.AppendLine();

            string subtotal = order.Subtotal.ToString("C");
            receipt.Append(' ', printCharacterMax - 15 - 9);
            receipt.Append("Subtotal:"); // 9 char long
            receipt.Append(' ', 15 - subtotal.Length);
            receipt.AppendLine(subtotal);

            string tax = Math.Round((order.Subtotal * TaxRate)).ToString("C");
            receipt.Append(' ', printCharacterMax - 15 - 4);
            receipt.Append("Tax:"); // 4 char long
            receipt.Append(' ', 15 - tax.Length);
            receipt.AppendLine(tax);

            receipt.Append('-', printCharacterMax);
            receipt.AppendLine();

            string total = order.TotalTax.ToString("C");
            receipt.Append(' ', printCharacterMax - 15 - 12);
            receipt.Append("Total:");
            receipt.Append(' ', 15 - total.Length);
            receipt.AppendLine(total);

            receipt.Append('-', printCharacterMax);
            receipt.AppendLine();

            receipt.Append(paymentType);
            string payedAmount = amountPaid.ToString("C");
            receipt.Append(' ', printCharacterMax - payedAmount.Length - paymentType.Length);
            receipt.AppendLine(payedAmount);
            receipt.AppendLine();

            string balance = (amountPaid - order.TotalTax).ToString("C");
            receipt.Append(' ', printCharacterMax - 15 - 8);
            receipt.Append("Balance:"); // 8 char long
            receipt.Append(' ', 15 - tax.Length);
            receipt.AppendLine(balance);
            receipt.AppendLine();
            receipt.AppendLine();
            receipt.AppendLine();
            receipt.AppendLine();

            return receipt.ToString();
        }

    }
}

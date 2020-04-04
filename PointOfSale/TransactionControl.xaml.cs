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

        public CashDrawer drawer = null;

        public TransactionControl()
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


        private void CashPayment_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new CashPaymentControl();
            screen.DataContext = drawer;

            orderControl.SwapScreen(screen);


        }

        private void CreditPayment_Click(object sender, RoutedEventArgs e)
        {
            string dateTime = DateTime.Now.ToString();
            ReceiptPrinter creditReceipt = new ReceiptPrinter();
            CardTerminal cardTransaction = new CardTerminal();
            switch (cardTransaction.ProcessTransaction(Total))
            {
                case ResultCode.Success:

                    creditReceipt.Print("Order Number: " + order.OrderNumber);
                    creditReceipt.Print("Date: " + dateTime);

                    foreach (IOrderItem item in order.Items)
                    {
                        creditReceipt.Print("");
                        creditReceipt.Print(item.ToString() + " " + item.Price.ToString());
                        foreach (string instruction in item.SpecialInstructions)
                        {
                            creditReceipt.Print("   " + instruction);
                        }
                    }

                    creditReceipt.Print("");
                    creditReceipt.Print("");

                    creditReceipt.Print("Subtotal: " + order.Subtotal);
                    creditReceipt.Print("Total (Tax = 16%): " + Total);
                    creditReceipt.Print("Payment Type: CREDIT");

                    this.DataContext = new Order();

                    var orderControl = this.FindAncestor<OrderControl>();
                    FrameworkElement screen = new MenuItemSelectionControl();
                    screen.DataContext = null;

                    orderControl.SwapScreen(screen);

                    MessageBox.Show("");
                    break;

                case ResultCode.ReadError:
                    MessageBox.Show("Unable to read card. Please try again or use a different form of payment");

                    break;

                case ResultCode.UnknownErrror:
                    break;

                case ResultCode.CancelledCard:
                    break;

                case ResultCode.InsufficentFunds:
                    break;

                default:
                    break;


            }

        }

        private void CancelTransaction_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MenuItemSelectionControl();
            screen.DataContext = null;

            orderControl.SwapScreen(screen);
        }


    }
}

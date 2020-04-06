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
using System.ComponentModel;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        /// <summary>
        /// This current transaction
        /// </summary>
        TransactionControl transaction;

        /// <summary>
        /// Handler that takes care of register and customer money
        /// </summary>
        private Money money;

        /// <summary>
        /// Initialize the CashControl with order
        /// </summary>
        public CashControl(double total, TransactionControl control)
        {
            InitializeComponent();

            transaction = control;
            money = new Money();
            DataContext = money;
            money.Total = total;
        }

        /// <summary>
        /// Generates the specefic amount of change to give back to customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculateChange(object sender, RoutedEventArgs e)
        {
            transaction.currentOrder.AmountPaid = money.cash.TotalValueGiven;
            if (money.cash.TotalValueGiven < money.Total)
            {
                MessageBox.Show($"Error: \n{"Not Enough Money for Transaction"}");
            }
            else
            {
                MessageBox.Show ($"Change To Give: " + (money.cash.TotalValueGiven - money.Total).ToString("C") +
                                  $"\nChange To Give (Quantity):\n{money.CalculateChangeToGiveBack(money.Total)}");
                Bills.IsEnabled = false;
                Coins.IsEnabled = false;
                DoneButton.IsEnabled = true;
                ChangeButton.IsEnabled = false;
            }
        }

        /// <summary>
        /// Complete the transaction upon order satisfaction
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Routed Event Args</param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            Bills.IsEnabled = true;
            Conis.IsEnabled = true;
            transaction.FinishCurrentTransaction();
        }
    }
}
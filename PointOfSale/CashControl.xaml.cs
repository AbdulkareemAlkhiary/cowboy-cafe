/* Author: Abdulkareem Alkhiary
 * Class: CashControl.xaml.cs 
 * Description: Handles all bills and coins interface */
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

        TransactionControl transaction;

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
        /// Amount of change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculateChange(object sender, RoutedEventArgs e)
        {
            transaction.current.AmountPaid = money.cash.Changetotal;
            if (money.cash.Changetotal < money.Total)
            {
                MessageBox.Show($"Error: \n{"Not Enough Money for Transaction"}");
            }
            else
            {
                MessageBox.Show ($"Change To Give: " + (money.cash.Changetotal - money.Total).ToString("C") +
                                  $"\nChange To Give (Quantity):\n{money.TotalChange(money.Total)}");
                Bills.IsEnabled = false;
                Coins.IsEnabled = false;
                DoneButton.IsEnabled = true;
                ChangeButton.IsEnabled = false;
            }
        }

        /// <summary>
        /// Complete the transaction
        /// </summary>
        /// <param name="sender">Sending Object</param>
        /// <param name="e">Routed Event Args</param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            Bills.IsEnabled = true;
            Coins.IsEnabled = true;
            transaction.FinishCurrentTransaction();
        }
    }
}
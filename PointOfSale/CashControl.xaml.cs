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
        /// The total cost of this current transaction
        /// </summary>
        private double total;

        /// <summary>
        /// Handler that takes care of register and customer money
        /// </summary>
        private Money money;

        /// <summary>
        /// Initialize the CashControl with order
        /// </summary>
        public CashControl(double total)
        {
            InitializeComponent();

            money = new Money();
            DataContext = money;
            //transaction = this.FindAncestor<TransactionControl>();
            this.total = total;
        }

        /// <summary>
        /// Generates the specefic amount of change to give back to customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculateChange(object sender, RoutedEventArgs e)
        {
            if (money.cash.TotalValueGiven < total)
            {
                MessageBox.Show("Error: Not Enough Money for Transaction");
            }
            else
            {
                MessageBox.Show($"Change To Give:\n{money.CalculateChangeToGiveBack(total)}");
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
            if (transaction != null)
            {
                transaction.FinishCurrentTransaction();
            }
        }
    }
}
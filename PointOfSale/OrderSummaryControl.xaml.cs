/* Author: Abdulkareem Alkhiary
 * Class: OrderSummaryControl.xaml.cs 
 * Description: Handles the order summary for application */
using CowboyCafe.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement orderElement)
                {
                    if (orderElement.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

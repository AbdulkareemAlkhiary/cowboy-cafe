/* Author: Abdulkareem Alkhiary
 * Class: OrderControl.xaml.cs 
 * Description: Handles I/O interface */
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
using CowboyCafe.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public OrderControl()
        {

            InitializeComponent();
            this.DataContext = new Order();
            ItemSelectButton.Click += ItemSelectButtonClicked;
            CompleteOrderButton.Click += CompleteOrderButtonClicked;
            CancelOrderButton.Click += CancelOrderButtonClicked;

        }

        
        /// <summary>
        /// Changes from main screen to options
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(FrameworkElement element) 
        {
            if (element != null)
            {
                Container.Child = element;
            }
        }

        /// <summary>
        /// Go back to main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemSelectButtonClicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Goes to new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Goes to new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            SwapScreen(new MenuItemSelectionControl());
        }

    }
}

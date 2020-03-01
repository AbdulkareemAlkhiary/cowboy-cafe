/* Author: Abdulkareem Alkhiary
 * Class: MenuItemSelectionControl.xaml.cs 
 * Description: Handles the menu item selection for application */
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            ItemSelectButton.Click += ItemSelectButtonClicked;
            CompleteOrderButton.Click += CompleteOrderButtonClicked;
            CancelOrderButton.Click += CancelOrderButtonClicked;
        }

        public void ItemSelectButtonClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException("To be implemented");
        }
        public void CompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        public void CancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}

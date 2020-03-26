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
using PointOfSale.DrinkCustomizations;
using PointOfSale.EntreeCustomizations;
using PointOfSale.SideCustomizations;

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
            FrameworkElement screen;
            OrderControl orderControl = null;

            // Need ancestor to load customization screen
            orderControl = this.FindAncestor<OrderControl>();

            if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");


            // Entrees ---------------------------------------------------------------------
            if (orderList.SelectedItem is IOrderItem item)
            {
                if (item is AngryChicken angryChicken)
                {

                    screen = new CustomizedAngryChicken(angryChicken);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = angryChicken;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is CowpokeChili cowpokeChili)
                {
                    screen = new CustomizedCowpokeChili(cowpokeChili);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = cowpokeChili;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is DakotaDoubleBurger dakotaDouble)
                {
                    screen = new CustomizedDakotaDoubleBurger(dakotaDouble);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = dakotaDouble;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is PecosPulledPork pecosPulledPork)
                {
                    screen = new CustomizedPecosPulledPork(pecosPulledPork);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = pecosPulledPork;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is TexasTripleBurger texasTriple)
                {
                    screen = new CustomizedTexasTripleBurger(texasTriple);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = texasTriple;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is TrailBurger trailBurger)
                {
                    screen = new CustomizedTrailBurger(trailBurger);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = trailBurger;
                        orderControl.SwapScreen(screen);
                    }
                }

                // Sides ---------------------------------------------------------------------
                else if (orderList.SelectedItem is BakedBeans bakedBeans)
                {
                    screen = new CustomizedBakedBeans(bakedBeans);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = bakedBeans;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is ChiliCheeseFries chiliCheeseFries)
                {
                    screen = new CustomizedChiliCheeseFries(chiliCheeseFries);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = chiliCheeseFries;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is CornDodgers cornDodgers)
                {
                    screen = new CustomizedCornDodgers(cornDodgers);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = cornDodgers;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is PanDeCampo panDeCampo)
                {
                    screen = new CustomizedPanDeCampo(panDeCampo);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = panDeCampo;
                        orderControl.SwapScreen(screen);
                    }
                }

                // Drinks ---------------------------------------------------------------------
                else if (orderList.SelectedItem is CowboyCoffee cowboyCoffee)
                {
                    screen = new CustomizedCowboyCoffee(cowboyCoffee);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = cowboyCoffee;
                        orderControl.SwapScreen(screen);
                    }

                }
                else if (orderList.SelectedItem is JerkedSoda jerkedSoda)
                {
                    screen = new CustomizedJerkedSoda(jerkedSoda);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = jerkedSoda;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is TexasTea texasTea)
                {
                    screen = new CustomizedTexasTea(texasTea);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = texasTea;
                        orderControl.SwapScreen(screen);
                    }
                }
                else if (orderList.SelectedItem is Water water)
                {
                    screen = new CustomizedWater(water);
                    if (screen != null)
                    {
                        // Need ancestor to load customization screen
                        orderControl = this.FindAncestor<OrderControl>();

                        if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                        // Add item to customization screen
                        screen.DataContext = water;
                        orderControl.SwapScreen(screen);
                    }
                }

                // All else ---------------------------------------------------------------------
                else
                {
                    // Add item to customization screen
                    orderControl?.SwapScreen(new MenuItemSelectionControl());
                }

                orderList.SelectedItem = null;
            }
        }

    }
}

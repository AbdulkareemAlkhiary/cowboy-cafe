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

            
        }

        /// <summary>
        /// Adds Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cowpoke_Chili(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizedCowpokeChili();
                screen.DataContext = screen;
                order.Add(entree);
                orderControl.SwapScreen(screen);
                
            }

        }

        /// <summary>
        /// Adds Rustler's Ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rustlers_Ribs(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
                orderControl.SwapScreen(new CustomizedRustlersRibs());
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pecos_Pulled_Pork(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
                orderControl.SwapScreen(new CustomizedPecosPulledPork());
            }
        }

        /// <summary>
        /// Adds Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trail_Burger(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
                orderControl.SwapScreen(new CustomizedTrailBurger());
            }
        }

        /// <summary>
        /// Adds Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dakota_Double_Burger(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
                orderControl.SwapScreen(new CustomizedDakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texas_Triple_Burger(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
                orderControl.SwapScreen(new CustomizedTexasTripleBurger());
            }
        }

        /// <summary>
        /// Adds Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angry_Chicken(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
                orderControl.SwapScreen(new CustomizedAngryChicken());
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chili_Cheese_Fries(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
                orderControl.SwapScreen(new CustomizedChiliChesseFries());
            }
        }

        /// <summary>
        /// Adds Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Corn_Dodgers(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
                orderControl.SwapScreen(new CustomizedCornDodgers());
            }
        }

        /// <summary>
        /// Adds Pan de Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pan_de_Campo(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
                orderControl.SwapScreen(new CustomizedPanDeCampo());
            }
        }

        /// <summary>
        /// Adds Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Baked_Beans(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
                orderControl.SwapScreen(new CustomizedBakedBeans());
            }
        }

        /// <summary>
        /// Add Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jerked_Soda(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
                orderControl.SwapScreen(new CustomizedJerkedSoda());
            }
        }

        /// <summary>
        /// Add Texas Tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texas_Tea(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
                orderControl.SwapScreen(new CustomizedTexasTea());
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cowboy_Coffee(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
                orderControl.SwapScreen(new CustomizedCowboyCoffee());
            }
        }

        /// <summary>
        /// Adds Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                order.Add(new Water());
                orderControl.SwapScreen(new CustomizedWater());
            }
        }
    }
}

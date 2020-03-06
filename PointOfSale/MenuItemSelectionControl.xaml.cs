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
                screen.DataContext = entree;
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
                var entree = new PecosPulledPork();
                var screen = new CustomizedPecosPulledPork();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
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
                var entree = new TrailBurger();
                var screen = new CustomizedTrailBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
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
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizedDakotaDoubleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
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
                var entree = new TexasTripleBurger();
                var screen = new CustomizedTexasTripleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
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
                var entree = new AngryChicken();
                var screen = new CustomizedAngryChicken();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
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
                var side = new ChiliCheeseFries();
                var screen = new CustomizedChiliCheeseFries();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
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
                var side = new CornDodgers();
                var screen = new CustomizedCornDodgers();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
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
                var side = new PanDeCampo();
                var screen = new CustomizedPanDeCampo();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
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
                var side = new BakedBeans();
                var screen = new CustomizedBakedBeans();
                screen.DataContext = side;
                order.Add(side);
                orderControl.SwapScreen(screen);
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
                var drinks = new JerkedSoda();
                var screen = new CustomizedJerkedSoda();
                screen.DataContext = drinks;
                order.Add(drinks);
                orderControl.SwapScreen(screen);
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
                var drinks = new TexasTea();
                var screen = new CustomizedTexasTea();
                screen.DataContext = drinks;
                order.Add(drinks);
                orderControl.SwapScreen(screen);
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
                var drinks = new CowboyCoffee();
                var screen = new CustomizedCowboyCoffee();
                screen.DataContext = drinks;
                order.Add(drinks);
                orderControl.SwapScreen(screen);
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
                var drinks = new Water();
                var screen = new CustomizedWater();
                screen.DataContext = drinks;
                order.Add(drinks);
                orderControl.SwapScreen(screen);
            }
        }
    }
}

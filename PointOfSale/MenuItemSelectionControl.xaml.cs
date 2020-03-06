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


        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // We need to have an Order to add this item to
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an Order instace");

            // Not all OrderItems need to be customized
            if(screen != null)
            {
                // We need to have an OrdeControl ancestor to load the customization
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of Ordercontrol..");

                // Add the item to the customization screen
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            // Add the item to the order
            order.Add(item);
        }

        /// <summary>
        /// Adds Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cowpoke_Chili(object sender, RoutedEventArgs e)
        {

                var entree = new CowpokeChili();
                var screen = new CustomizedCowpokeChili();
                AddItemAndOpenCustomizationScreen(entree, screen);
                
            

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
                var entree = new PecosPulledPork();
                var screen = new CustomizedPecosPulledPork();
                AddItemAndOpenCustomizationScreen(entree, screen);
            
        }

        /// <summary>
        /// Adds Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trail_Burger(object sender, RoutedEventArgs e)
        {
                var entree = new TrailBurger();
                var screen = new CustomizedTrailBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);
            
        }

        /// <summary>
        /// Adds Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dakota_Double_Burger(object sender, RoutedEventArgs e)
        {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizedDakotaDoubleBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }

        /// <summary>
        /// Adds Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texas_Triple_Burger(object sender, RoutedEventArgs e)
        {
                var entree = new TexasTripleBurger();
                var screen = new CustomizedTexasTripleBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }

        /// <summary>
        /// Adds Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angry_Chicken(object sender, RoutedEventArgs e)
        {
                var entree = new AngryChicken();
                var screen = new CustomizedAngryChicken();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }

        /// <summary>
        /// Adds Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chili_Cheese_Fries(object sender, RoutedEventArgs e)
        {
                var side = new ChiliCheeseFries();
                var screen = new CustomizedChiliCheeseFries();
                AddItemAndOpenCustomizationScreen(side, screen);
            }

        /// <summary>
        /// Adds Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Corn_Dodgers(object sender, RoutedEventArgs e)
        {
                var side = new CornDodgers();
                var screen = new CustomizedCornDodgers();
                AddItemAndOpenCustomizationScreen(side, screen);
            }

        /// <summary>
        /// Adds Pan de Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pan_de_Campo(object sender, RoutedEventArgs e)
        {
                var side = new PanDeCampo();
                var screen = new CustomizedPanDeCampo();
                AddItemAndOpenCustomizationScreen(side, screen);
            }

        /// <summary>
        /// Adds Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Baked_Beans(object sender, RoutedEventArgs e)
        {
                var side = new BakedBeans();
                var screen = new CustomizedBakedBeans();
                AddItemAndOpenCustomizationScreen(side, screen);
            }

        /// <summary>
        /// Add Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jerked_Soda(object sender, RoutedEventArgs e)
        {
                var drinks = new JerkedSoda();
                var screen = new CustomizedJerkedSoda();
                AddItemAndOpenCustomizationScreen(drinks, screen);
            }

        /// <summary>
        /// Add Texas Tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texas_Tea(object sender, RoutedEventArgs e)
        {
                var drinks = new TexasTea();
                var screen = new CustomizedTexasTea();
                AddItemAndOpenCustomizationScreen(drinks, screen);
            }

        /// <summary>
        /// Adds Cowboy Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cowboy_Coffee(object sender, RoutedEventArgs e)
        {
                var drinks = new CowboyCoffee();
                var screen = new CustomizedCowboyCoffee();
                AddItemAndOpenCustomizationScreen(drinks, screen);
            }

        /// <summary>
        /// Adds Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water(object sender, RoutedEventArgs e)
        {
                var drinks = new Water();
                var screen = new CustomizedWater();
                AddItemAndOpenCustomizationScreen(drinks, screen);
            }
    }
}

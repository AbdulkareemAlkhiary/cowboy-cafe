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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        private Order OrderList;

        public OrderControl()
        {

            InitializeComponent();

            OrderList = new Order();
            this.DataContext = OrderList;
        }

        /// <summary>
        /// Adds Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cowpoke_Chili(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CowpokeChili());

        }

        /// <summary>
        /// Adds Rustler's Ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rustlers_Ribs(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new RustlersRibs());
        }

        /// <summary>
        /// Adds Pecos Pulled Pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pecos_Pulled_Pork(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Adds Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trail_Burger(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TrailBurger());
        }

        /// <summary>
        /// Adds Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dakota_Double_Burger(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Adds Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texas_Triple_Burger(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Adds Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angry_Chicken(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new AngryChicken());
        }

        /// <summary>
        /// Adds Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chili_Cheese_Fries(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Adds Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Corn_Dodgers(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CornDodgers());
        }

        /// <summary>
        /// Adds Pan de Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pan_de_Campo(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new PanDeCampo());
        }

        /// <summary>
        /// Adds Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Baked_Beans(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new BakedBeans());
        }

        /// <summary>
        /// Add Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jerked_Soda(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new JerkedSoda());
        }

        /// <summary>
        /// Add Texas Tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Texas_Tea(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new TexasTea());
        }

        /// <summary>
        /// Adds Cowboy Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cowboy_Coffee(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Adds Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water(object sender, RoutedEventArgs e)
        {
            OrderList.Add(new Water());
        }

    }
}

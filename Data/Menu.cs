/* Author: Abdulkareem Alkhiary
 * Class: Menu.cs 
 * Description: Handles website menu */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Data refactoring
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> OrderItems()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo(),

                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger(),

                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
            return orderItems;
        }



        /// <summary>
        /// All the entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeItems = new List<IOrderItem>
            {

                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };
            return entreeItems;
        }

        /// <summary>
        /// All the drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkItems = new List<IOrderItem>
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
            return drinkItems;
        }

        /// <summary>
        /// All the sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideItems = new List<IOrderItem>
            { 
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };
            return sideItems;
        }

    }
}

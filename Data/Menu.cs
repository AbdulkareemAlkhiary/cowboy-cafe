/* Author: Abdulkareem Alkhiary
 * Class: Menu.cs 
 * Description: Handles website menu */
using System;
using System.Collections.Generic;
using System.Linq;
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
            List<IOrderItem> orderItems = new List<IOrderItem>();
            foreach (IOrderItem item in Entrees())
            {
                orderItems.Add(item);
            }

            foreach (IOrderItem item in Sides())
            {
                orderItems.Add(item);
            }

            foreach (IOrderItem item in Drinks())
            {
                orderItems.Add(item);
            }



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
            List<IOrderItem> drinkItems = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                JerkedSoda soda = new JerkedSoda();
                soda.Size = size;
                drinkItems.Add(soda);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                Water w = new Water();
                w.Size = size;
                drinkItems.Add(w);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CowboyCoffee coffee = new CowboyCoffee();
                coffee.Size = size;
                drinkItems.Add(coffee);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                TexasTea tea = new TexasTea();
                tea.Size = size;
                drinkItems.Add(tea);
            }

            return drinkItems;
        }

        /// <summary>
        /// All the sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideItems = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans beans = new BakedBeans();
                beans.Size = size;
                sideItems.Add(beans);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                ChiliCheeseFries fries = new ChiliCheeseFries();
                fries.Size = size;
                sideItems.Add(fries);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CornDodgers corn = new CornDodgers();
                corn.Size = size;
                sideItems.Add(corn);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                PanDeCampo de = new PanDeCampo();
                de.Size = size;
                sideItems.Add(de);
            }

            return sideItems;
        }

        public static IEnumerable<IOrderItem> Search(string terms, IEnumerable<IOrderItem> items)
        {

            // Return all movies if there are no search terms
            if (terms == null) return OrderItems();

            return items.Where(item => item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase));

        }

        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] types)
        {
            IEnumerable<IOrderItem> t = null;
            if (types == null || types.Length == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            foreach (string type in types)
            {
                switch (type)
                {
                    case "Entree":
                        t = items.Where(item => item is Entree);
                        break;
                    case "Side":
                        t = items.Where(item => item is Side);
                        break;
                    case "Drink":
                        t = items.Where(item => item is Drink);
                        break;
                    default:
                        return items;
                }
                foreach (IOrderItem item in t)
                {
                    result.Add(item);
                }
                t = null;
            }
            return result;
        }

        /// <summary>
        /// Filters the provided collection of items by price 
        /// within the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            if (min == null) min = 0;
            if (max == null) max = 10;
            return items.Where(item => item.Price >= min && item.Price <= max);

        }

        /// <summary>
        /// Filters the provided collection of items by Calories 
        /// within the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            if (max == null) max = 10;
            if (min == null) min = 0;
            return items.Where(item => item.Calories >= min && item.Calories <= max);

        }
    }
}

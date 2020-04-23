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
        /// Changes size of drink
        /// </summary>
        /// <param name="d"></param>
        /// <param name="s"></param>
        public static void SizeDrink(Drink d, Size s)
        {
            d.Size = s;
        }

        /// <summary>
        /// Changes size of side
        /// </summary>
        /// <param name="s"></param>
        /// <param name="size"></param>
        public static void SizeSide(Side s, Size size)
        {
            s.Size = size;
        }
                
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

        public static IEnumerable<IOrderItem> Search(string terms)
        {
            // TODO: Search database
            List<IOrderItem> results = new List<IOrderItem>();

            // Return all movies if there are no search terms
            if (terms == null) return OrderItems();


            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in OrderItems())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item); ;
                }
            }

            return results;

        }

        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] types)
        {
            if (types == null || types.Length == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            foreach (string type in types)
            {
                switch (type)
                {
                    case "Entree":
                        foreach (IOrderItem item in items)
                        {
                            if (item is Entree) result.Add(item);
                        }
                        break;
                    case "Side":
                        foreach (IOrderItem item in items)
                        {
                            if (item is Side) result.Add(item);
                        }
                        break;
                    case "Drink":
                        foreach (IOrderItem item in items)
                        {
                            if (item is Drink) result.Add(item);
                        }
                        break;
                    default:
                        return items;
                }
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
            // TODO: Filter price
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;

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
            // TODO: Filter price
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }

    }
}

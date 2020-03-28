/* Author: Abdulkareem Alkhiary
 * Class: OrderPropertyChangedTests.cs 
 * Description: Handles the Order Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class OrderPropertyChangedTests
    {
        /// <summary>
        /// Tests if Order class implements INotifyPropertyChanged
        /// Interface.
        /// </summary>
        [Fact]
        public void OrderClassImplementsINotifyPropertyChanged()
        {
            Order order = new Order();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        /// <summary>
        /// Tests if order class notifies PropertyChanged
        /// </summary>
        [Fact]
        public void ChangingItemsPropertiesShouldInvokePropertyChangedForItems()
        {
            var coffee = new CowboyCoffee();
            var tripleBurger = new TexasTripleBurger();
            var soda = new JerkedSoda();
            var chili = new CowpokeChili();

            var order = new Order();

            order.Add(coffee);
            order.Add(tripleBurger);
            order.Add(soda);
            order.Add(chili);

            Assert.PropertyChanged(order, "Items", () => { coffee.Ice = true; });

            Assert.PropertyChanged(order, "Items", () => { coffee.Decaf = true; });

            Assert.PropertyChanged(order, "Items", () => { coffee.Size = Size.Medium; });

            Assert.PropertyChanged(order, "Items", () => { tripleBurger.Cheese = false; });

            Assert.PropertyChanged(order, "Items", () => { tripleBurger.Bun = false; });

            Assert.PropertyChanged(order, "Items", () => { soda.Flavor = SodaFlavor.BirchBeer; });

            Assert.PropertyChanged(order, "Items", () => { soda.Size = Size.Large; });

            Assert.PropertyChanged(order, "Items", () => { chili.Cheese = false; });

            Assert.PropertyChanged(order, "Items", () => { chili.GreenOnions = false; });
        }

        /// <summary>
        /// Tests if order class notifies PropertyChanged
        /// </summary>
        [Fact]
        public void ChangingItemsPropertiesAffectCostShouldInvokePropertyChangedForSubtotalProperty()
        {
            var soda = new JerkedSoda();
            var corn = new CornDodgers();
            var beans = new BakedBeans();
            var pan = new PanDeCampo();
            var fries = new ChiliCheeseFries();

            var order = new Order();

            order.Add(soda);
            order.Add(corn);
            order.Add(beans);
            order.Add(pan);
            order.Add(fries);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                soda.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                corn.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                beans.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                pan.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                fries.Size = Size.Large;
            });
        }

    }
}

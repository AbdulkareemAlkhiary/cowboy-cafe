/* Author: Abdulkareem Alkhiary
 * Class: TrailBurgerPropertyChangedTests.cs 
 * Description: Handles the Trail Burger Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void TrailBurgerShouldImplrementINotifyPropertyChanged()
        {
            var burger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Testing Bun property
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }

        /// <summary>
        /// Testing Ketchup property
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }

        /// <summary>
        /// Testing Mustard property
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            {
                var burger = new TrailBurger();
                Assert.PropertyChanged(burger, "Mustard", () =>
                {
                    burger.Mustard = false;
                });
            }
        }

        /// <summary>
        /// Testing Pickle property
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }

        /// <summary>
        /// Testing Cheese property
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing the Bun property
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });
        }

        /// <summary>
        /// Changing the Ketchup property
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });
        }

        /// <summary>
        /// Changing the Mustard property
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });
        }

        /// <summary>
        /// Changing the Pickle property
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Pickle = false;
            });
        }

        /// <summary>
        /// Changing the Cheese property
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }
    }
}

/* Author: Abdulkareem Alkhiary
 * Class: TexasTripleBurgerPropertyChangedTests.cs 
 * Description: Handles the Texas Triple Burger Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void TexasTripleBurgerShouldImplrementINotifyPropertyChanged()
        {
            var burger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Testing Bun property
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
                var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }

        /// <summary>
        /// Testing Tomato property
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = false;
            });
        }


        /// <summary>
        /// Testing Lettuce property
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = false;
            });
        }

        /// <summary>
        /// Testing Mayo property
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = false;
            });
        }

        /// <summary>
        /// Testing Bacon property
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Bacon", () =>
            {
                burger.Bacon = false;
            });
        }

        /// <summary>
        /// Testing Egg property
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Egg", () =>
            {
                burger.Egg = false;
            });
        }

        /// <summary>
        /// Changing the Bun property
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }

        /// <summary>
        /// Changing the Tomato property
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Tomato = false;
            });
        }

        /// <summary>
        /// Changing the Lettuce property
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Lettuce = false;
            });
        }

        /// <summary>
        /// Changing the Mayo property
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mayo = false;
            });
        }

        /// <summary>
        /// Changing the Bacon property
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bacon = false;
            });
        }

        /// <summary>
        /// Changing the Egg property
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Egg = false;
            });
        }
    }
}
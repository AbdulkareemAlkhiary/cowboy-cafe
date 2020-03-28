/* Author: Abdulkareem Alkhiary
 * Class: CowboyCoffeePropertyChangedTests.cs 
 * Description: Handles the Cowboy Coffee Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplrementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        /// <summary>
        /// Checks Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void CowboyCoffeeSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            CowboyCoffee coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = size;
            });
        }

        /// <summary>
        /// Checks Property changed for Price
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void CowboyCoffeeSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            CowboyCoffee coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = size;
            });
        }

        /// <summary>
        /// Checks Property changed for Calories
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void CowboyCoffeeSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            CowboyCoffee coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = size;
            });
        }

        /// <summary>
        /// Testing Decaf property
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = false;
            });
        }

        /// <summary>
        /// Testing Ice property
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = false;
            });
        }

        /// <summary>
        /// Testing RoomForCream property
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Changing the Decaf property
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
        }

        /// <summary>
        /// Changing the RoomForCream property
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }

        /// <summary>
        /// Changing the Ice property
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }
    }
}
/* Author: Abdulkareem Alkhiary
 * Class: WaterPropertyChangedTests.cs 
 * Description: Handles the Water Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void WaterShouldImplrementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }


        /// <summary>
        /// Testing Ice property
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Testing Lemon property
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });
        }


        /// <summary>
        /// Changing the Lemon property
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }

        /// <summary>
        /// Changing the Ice property
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Checks Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void WaterSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = size;
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
        public void WaterCoffeeSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = size;
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
        public void WaterSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = size;
            });
        }
    }
}
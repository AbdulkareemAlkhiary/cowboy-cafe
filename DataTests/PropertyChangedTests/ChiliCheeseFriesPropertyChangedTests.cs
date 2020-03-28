/* Author: Abdulkareem Alkhiary
 * Class: ChiliCheeseFriesPropertyChangedTests.cs 
 * Description: Handles the Chili Cheese Fries Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesShouldImplrementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        /// <summary>
        /// Checks Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChiliCheeseFriesSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            ChiliCheeseFries fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = size;
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
        public void ChiliCheeseFriesSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            ChiliCheeseFries fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = size;
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
        public void ChiliCheeseFriesSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            ChiliCheeseFries fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = size;
            });
        }
    }
}
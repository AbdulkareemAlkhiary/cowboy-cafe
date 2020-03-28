/* Author: Abdulkareem Alkhiary
 * Class: CornDodgersPropertyChangedTests.cs 
 * Description: Handles the Corn Dodgers Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplrementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        /// <summary>
        /// Checks Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void CornDodgersFriesSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            CornDodgers corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = size;
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
        public void CornDodgersSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            CornDodgers corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = size;
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
        public void CornDodgersSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            CornDodgers corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = size;
            });
        }
    }
}

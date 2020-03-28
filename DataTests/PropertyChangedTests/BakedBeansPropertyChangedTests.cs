/* Author: Abdulkareem Alkhiary
 * Class: BakedBeansPropertyChangedTests.cs 
 * Description: Handles the Baked Beans Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void BakedBeansShouldImplrementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        /// <summary>
        /// Checks Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void BakedBeansSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = size;
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
        public void BakedBeansSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = size;
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
        public void BakedBeansSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = size;
            });
        }
    }
}
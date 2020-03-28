/* Author: Abdulkareem Alkhiary
 * Class: PanDeCampoPropertyChangedTests.cs 
 * Description: Handles the Pan De Campo Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplrementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        /// <summary>
        /// Checks size property
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void PanDeCampoFriesSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            PanDeCampo pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = size;
            });
        }

        /// <summary>
        /// Checks size property
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void PanDeCampoSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            PanDeCampo pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = size;
            });
        }

        /// <summary>
        /// Checks size property
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void PanDeCampoSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            PanDeCampo pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = size;
            });
        }
    }
}

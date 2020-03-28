/* Author: Abdulkareem Alkhiary
 * Class: JerkedSodaPropertyChangedTests.cs 
 * Description: Handles the Jerked Soda Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplrementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        /// <summary>
        /// Changing the Ice property
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        /// <summary>
        /// Changing the Ice property
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
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
        public void JerkedSodaSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            JerkedSoda soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = size;
            });
        }

        /// <summary>
        /// Checks flavor property
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(SodaFlavor.CreamSoda)]
        [InlineData(SodaFlavor.OrangeSoda)]
        [InlineData(SodaFlavor.RootBeer)]
        [InlineData(SodaFlavor.BirchBeer)]
        [InlineData(SodaFlavor.Sarsparilla)]
        public void JerkedSodaFlavorChangeShouldNotifyPropertyChanged(SodaFlavor flavor)
        {
            JerkedSoda soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = flavor;
            });
        }

        /// <summary>
        /// Checks calories property
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void JerkedSodaCaloriesChangeShouldNotifyPropertyChanged(Size size)
        {
            JerkedSoda soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = size;
            });
        }

        /// <summary>
        /// Checks price property
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void JerkedSodaPriceChangeShouldNotifyPropertyChanged(Size size)
        {
            JerkedSoda soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = size;
            });
        }
    }
}

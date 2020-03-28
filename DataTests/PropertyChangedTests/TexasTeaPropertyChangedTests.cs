/* Author: Abdulkareem Alkhiary
 * Class: TexasTeaPropertyChangedTests.cs 
 * Description: Handles the Texas Tea Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void TexasTeaShouldImplrementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        /// <summary>
        /// Testing Sweet property
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }

        /// <summary>
        /// Testing Ice property
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }

        /// <summary>
        /// Testing Lemon property
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }

        /// <summary>
        /// Changing the Sweet property
        /// </summary>
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }

        /// <summary>
        /// Changing the Lemon property
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }

        /// <summary>
        /// Changing the Ice property
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
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
        public void TexasTeaSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            TexasTea tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = size;
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
        public void TexasTeaCaloriesChangeShouldNotifyPropertyChanged(Size size)
        {
            TexasTea tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = size;
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
        public void TexasTeaPriceChangeShouldNotifyPropertyChanged(Size size)
        {
            TexasTea tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = size;
            });
        }
    }
}

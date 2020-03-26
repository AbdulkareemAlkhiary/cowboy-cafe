using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplrementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        /// <summary>
        /// Testing Cheese property for invocation of PropertyChanged for Cheese
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// Testing Sour Cream property for invocation of PropertyChanged for Sour Cream
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// Testing Green Onions property for invocation of PropertyChanged for Green Onions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Testing Tortilla Strips property for invocation of PropertyChanged for Tortilla Strips
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }

        /// <summary>
        /// Changing the Cheese property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// Changing the Sour Cream property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// Changing the Green Onions property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Changing the Tortilla Strips property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
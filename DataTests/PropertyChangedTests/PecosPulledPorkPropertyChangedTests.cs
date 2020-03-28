/* Author: Abdulkareem Alkhiary
 * Class: PecosPulledPorkPropertyChangedTests.cs 
 * Description: Handles the Pecos Pulled Pork Property Changed Tests */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void PecosPulledPorkShouldImplrementINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }

        /// <summary>
        /// Testing bread property
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });
        }

        /// <summary>
        /// Testing bread property
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }

        /// <summary>
        /// Changing the Bread property
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }

        /// <summary>
        /// Changing the Pickle property
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }
    }
}
﻿/* Author: Abdulkareem Alkhiary
 * Class: CoinControl.xaml.cs 
 * Description: Handles coins interface */
using CashRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {

        // Using a DependencyProperty as the backing store for the Denomination Property.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",                     // The name of the property
                typeof(Coins),                      // The type of the property
                typeof(CoinControl),                // The property's control
                new PropertyMetadata(Coins.Penny)   // The Property Medata
                );


        /// <summary>
        /// The denomination of the coin
        /// </summary>
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }


        /// <summary>
        /// The DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityGivenProperty =
                DependencyProperty.Register(
                    "QuantityGiven",
                    typeof(int),
                    typeof(CoinControl),
                    new FrameworkPropertyMetadata(
                        0,
                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// The DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityDrawerProperty =
                DependencyProperty.Register(
                    "QuantityDrawer",
                    typeof(int),
                    typeof(CoinControl),
                    new FrameworkPropertyMetadata(
                        0,
                        FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                    )
                );

        /// <summary>
        /// The quantity of the coin denomination
        /// </summary>
        public int QuantityGiven
        {
            get { return (int)GetValue(QuantityGivenProperty); }
            set { SetValue(QuantityGivenProperty, value); }
        }

        /// <summary>
        /// The quantity of the coin denomination
        /// </summary>
        public int QuantityDrawer
        {
            get { return (int)GetValue(QuantityDrawerProperty); }
            set { SetValue(QuantityDrawerProperty, value); }
        }

        /// <summary>
        /// Increases the quantity of the bound coinage by one
        /// </summary>
        /// <param name="sender">The coinage quanity (as an int)</param>
        /// <param name="args">The event args</param>
        public void OnAddClicked(object sender, RoutedEventArgs args)
        {
            QuantityGiven++;
        }

        /// <summary>
        /// Decreases the quantity of the bound coinage by one
        /// </summary>
        /// <param name="sender">The coinage quantity (as in int)</param>
        /// <param name="args">The event args</param>
        public void OnRemoveClicked(object sender, RoutedEventArgs args)
        {
            QuantityGiven--;
        }


        public CoinControl()
        {
            InitializeComponent();
        }
    }
}
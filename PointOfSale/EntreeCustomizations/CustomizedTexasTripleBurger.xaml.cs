﻿/* Author: Abdulkareem Alkhiary
 * Class: CustomizedTexasTripleBurger.xaml.cs 
 * Description: The window for customizations of this item */
using CowboyCafe.Data;
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

namespace PointOfSale.EntreeCustomizations
{
    /// <summary>
    /// Interaction logic for CustomizedCowpokeChili.xaml
    /// </summary>
    public partial class CustomizedTexasTripleBurger : UserControl
    {
        public CustomizedTexasTripleBurger()
        {
            InitializeComponent();
        }

        private TexasTripleBurger c;
        public CustomizedTexasTripleBurger(TexasTripleBurger cc)
        {
            c = cc;
            InitializeComponent();
        }


    }
}

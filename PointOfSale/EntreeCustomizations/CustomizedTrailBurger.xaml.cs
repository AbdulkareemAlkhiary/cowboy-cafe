﻿/* Author: Abdulkareem Alkhiary
 * Class: CustomizedTrailBuger.xaml.cs 
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
    public partial class CustomizedTrailBurger : UserControl
    {
        public CustomizedTrailBurger()
        {
            InitializeComponent();
        }

        private TrailBurger c;
        public CustomizedTrailBurger(TrailBurger cc)
        {
            c = cc;
            InitializeComponent();
        }
    }
}

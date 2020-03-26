﻿/* Author: Abdulkareem Alkhiary
 * Class: CustomizedPecosPulledPork.xaml.cs 
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
    public partial class CustomizedPecosPulledPork : UserControl
    {
        public CustomizedPecosPulledPork()
        {
            InitializeComponent();
        }

        private PecosPulledPork c;
        public CustomizedPecosPulledPork(PecosPulledPork cc)
        {
            c = cc;
            InitializeComponent();
        }
    }
}

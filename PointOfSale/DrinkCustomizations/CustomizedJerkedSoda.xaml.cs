﻿/* Author: Abdulkareem Alkhiary
 * Class: CustomizedJerkedSoda.xaml.cs 
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

namespace PointOfSale.DrinkCustomizations
{
    /// <summary>
    /// Interaction logic for CustomizedJerkedSoda.xaml
    /// </summary>
    public partial class CustomizedJerkedSoda : UserControl
    {
        public CustomizedJerkedSoda()
        {
            InitializeComponent();
        }

        private JerkedSoda c;
        public CustomizedJerkedSoda(JerkedSoda cc)
        {
            c = cc;
            InitializeComponent();
        }
    }
}

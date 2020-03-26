/* Author: Abdulkareem Alkhiary
 * Class: CustomizedTexasTea.xaml.cs 
 * Description: The window for customizations of this item */
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
using CowboyCafe.Data;

namespace PointOfSale.DrinkCustomizations
{
    /// <summary>
    /// Interaction logic for CustomizedTexasTea.xaml
    /// </summary>
    public partial class CustomizedTexasTea : UserControl
    {
        public CustomizedTexasTea()
        {
            InitializeComponent();
        }

        private TexasTea c;
        public CustomizedTexasTea(TexasTea cc)
        {
            c = cc;
            InitializeComponent();
        }
    }
}

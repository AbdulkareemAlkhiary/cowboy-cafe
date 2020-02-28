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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void Cowpoke_Chili(object sender, RoutedEventArgs e)
        {
            CowpokeChili cc = new CowpokeChili();
            PriceList.Items.Add(cc.Price);
            OrderList.Items.Add(cc);
        }

        private void Rustlers_Ribs(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new RustlersRibs().Price);
        }

        private void Pecos_Pulled_Pork(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new PecosPulledPork().Price);
        }

        private void Trail_Burger(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new TrailBurger().Price);
        }

        private void Dakota_Double_Burger(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new DakotaDoubleBurger().Price);
        }

        private void Texas_Triple_Burger(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new TexasTripleBurger().Price);
        }

        private void Angry_Chicken(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new AngryChicken().Price);
        }

        private void Chili_Cheese_Fries(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new ChiliCheeseFries().Price);
        }

        private void Corn_Dodgers(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new CornDodgers().Price);
        }

        private void Pan_de_Campo(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new PanDeCampo().Price);
        }

        private void Baked_Beans(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new BakedBeans().Price);
        }

        private void Jerked_Soda(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new JerkedSoda().Price);
        }

        private void Texas_Tea(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new TexasTea().Price);
        }

        private void Cowboy_Coffee(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new CowboyCoffee().Price);
        }

        private void Water(object sender, RoutedEventArgs e)
        {
            PriceList.Items.Add(new Water().Price);
        }
    }
}

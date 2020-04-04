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
using System.ComponentModel;

namespace PointOfSale
{

    public partial class CashControl : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CashControl()
        {
            InitializeComponent();
        }

        private int hundred = 0;

        public int Hundred
        {
            get { return hundred; }
            set
            {
                if (int.TryParse(HundredBox.Text, out value))
                {
                    //parsing successful 
                    hundred = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundred"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int fifty = 0;

        public int Fifty
        {
            get { return fifty; }
            set
            {
                if (int.TryParse(FiftyBox.Text, out value))
                {
                    //parsing successful 
                    fifty = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifty"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int twenty = 0;

        public int Twenty
        {
            get { return twenty; }
            set
            {
                if (int.TryParse(TwentyBox.Text, out value))
                {
                    //parsing successful 
                    twenty = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenty"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int ten = 0;

        public int Ten
        {
            get { return ten; }
            set
            {
                if (int.TryParse(TenBox.Text, out value))
                {
                    //parsing successful 
                    ten = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ten"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int five = 0;

        public int Five
        {
            get { return five; }
            set
            {
                if (int.TryParse(FiveBox.Text, out value))
                {
                    //parsing successful 
                    five = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Five"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int two = 0;

        public int Two
        {
            get { return two; }
            set
            {
                if (int.TryParse(TwoBox.Text, out value))
                {
                    //parsing successful 
                    two = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Two"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int one = 0;

        public int One
        {
            get { return one; }
            set
            {
                if (int.TryParse(OneBox.Text, out value))
                {
                    //parsing successful 
                    one = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("One"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int dollarCoin = 0;

        public int DollarCoin
        {
            get { return dollarCoin; }
            set
            {
                if (int.TryParse(DollarCoinBox.Text, out value))
                {
                    //parsing successful 
                    dollarCoin = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoin"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int halfDollar = 0;

        public int HalfDollar
        {
            get { return halfDollar; }
            set
            {
                if (int.TryParse(HalfDollarBox.Text, out value))
                {
                    //parsing successful 
                    halfDollar = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollar"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int quarter = 0;

        public int Quarter
        {
            get { return quarter; }
            set
            {
                if (int.TryParse(QuarterBox.Text, out value))
                {
                    //parsing successful 
                    quarter = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarter"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int dime = 0;

        public int Dime
        {
            get { return dime; }
            set
            {
                if (int.TryParse(DimeBox.Text, out value))
                {
                    //parsing successful 
                    dime = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dime"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int nickel = 0;

        public int Nickel
        {
            get { return nickel; }
            set
            {
                if (int.TryParse(NickelBox.Text, out value))
                {
                    //parsing successful 
                    nickel = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickel"));
                    MessageBox.Show("Needs to be an integer value");
                }
            }
        }

        private int penny = 0;

        public int Penny
        {
            get { return penny; }
            set
            {
                if (int.TryParse(PennyBox.Text, out value))
                {
                    //parsing successful 
                    penny = value;
                }
                else
                {
                    //parsing failed. 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Penny"));
                    MessageBox.Show("Needs to be an integer value");

                }
            }
        }


        private void PayCash_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MenuItemSelectionControl();
            screen.DataContext = null;

            orderControl.SwapScreen(screen);
        }
    }
}
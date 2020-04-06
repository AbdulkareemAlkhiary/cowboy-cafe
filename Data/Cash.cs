/* Author: Abdulkareem Alkhiary
 * Class: Cash.cs 
 * Description: Handles cash in register */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// Cash received by customer
    /// </summary>
    public class Cash : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes the PropertyChanged event 
        /// </summary>
        /// <param name="denomination">Changing property</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValueGiven"));
        }

        public double TotalValueGiven
        {
            get
            {
                double totalGiven = 0;
                totalGiven += 100.00 * Hundreds;
                totalGiven += 50.00 * Fifties;
                totalGiven += 20.00 * Twenties;
                totalGiven += 10.00 * Tens;
                totalGiven += 5.00 * Fives;
                totalGiven += 2.00 * Twos;
                totalGiven += 1.00 * Dollars;
                totalGiven += 0.50 * HalfDollars;
                totalGiven += 0.25 * Quarters;
                totalGiven += 0.10 * Dimes;
                totalGiven += 0.05 * Nickels;
                totalGiven += 0.01 * Pennies;
                return totalGiven;
            }
        }


        private int pennies = 0;

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => pennies;

            set
            {
                if (pennies == value || value < 0) return;
                else
                {
                    pennies = value;
                    InvokePropertyChanged("Pennies");
                }
            }
        }

        private int nickels = 0;

        /// <summary>
        /// Gets or sets the number of Nickels in the cash register
        /// </summary>
        public int Nickels
        {
            get => nickels;

            set
            {
                if (nickels == value || value < 0) return;
                else
                {
                    nickels = value;
                    InvokePropertyChanged("Nickels");
                }
            }
        }

        private int dimes = 0;

        /// <summary>
        /// Gets or sets the number of Dimes in the cash register
        /// </summary>
        public int Dimes
        {
            get => dimes;

            set
            {
                if (dimes == value || value < 0) return;
                else
                {
                    dimes = value;
                    InvokePropertyChanged("Dimes");
                }
            }
        }

        private int quarters = 0;

        /// <summary>
        /// Gets or sets the number of Quarter in the cash register
        /// </summary>
        public int Quarters
        {
            get => quarters;

            set
            {
                if (quarters == value || value < 0) return;
                else
                {
                    quarters = value;
                    InvokePropertyChanged("Quarters");
                }
            }
        }

        private int halfDollars = 0;

        /// <summary>
        /// Gets or sets the number of half-dollars in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => halfDollars;

            set
            {
                if (halfDollars == value || value < 0) return;
                else
                {
                    halfDollars = value;
                    InvokePropertyChanged("HalfDollars");
                }
            }
        }

        private int dollars = 0;

        /// <summary>
        /// Gets or sets the number of Dollar coins in the cash register
        /// </summary>
        public int Dollars
        {
            get => dollars;

            set
            {
                if (dollars == value || value < 0) return;
                else
                {
                    dollars = value;
                    InvokePropertyChanged("Dollars");
                }
            }
        }

        private int ones = 0;

        /// <summary>
        /// Gets or sets the number of one bills in the cash register
        /// </summary>
        public int Ones
        {
            get => ones;

            set
            {
                if (ones == value || value < 0) return;
                else
                {
                    ones = value;
                    InvokePropertyChanged("Ones");
                }
            }
        }

        private int twos = 0;

        /// <summary>
        /// Gets or sets the number of two bills in the cash register
        /// </summary>
        public int Twos
        {
            get => twos;

            set
            {
                if (twos == value || value < 0) return;
                else
                {
                    twos = value;
                    InvokePropertyChanged("Twos");
                }
            }
        }

        private int fives = 0;

        /// <summary>
        /// Gets or sets the number of five bills in the cash register
        /// </summary>
        public int Fives
        {
            get => fives;

            set
            {
                if (fives == value || value < 0) return;
                else
                {
                    fives = value;
                    InvokePropertyChanged("Fives");
                }
            }
        }

        private int tens = 0;

        /// <summary>
        /// Gets or sets the number of ten bills in the cash register
        /// </summary>
        public int Tens
        {
            get => tens;

            set
            {
                if (tens == value || value < 0) return;
                else
                {
                    tens = value;
                    InvokePropertyChanged("Tens");
                }
            }
        }

        private int twenties = 0;

        /// <summary>
        /// Gets or sets the number of twenty bills in the cash register
        /// </summary>
        public int Twenties
        {
            get => twenties;

            set
            {
                if (twenties == value || value < 0) return;
                else
                {
                    twenties = value;
                    InvokePropertyChanged("Twenties");
                }
            }
        }

        private int fifties = 0;

        /// <summary>
        /// Gets or sets the number of fifty bills in the cash register
        /// </summary>
        public int Fifties
        {
            get => fifties;

            set
            {
                if (fifties == value || value < 0) return;
                else
                {
                    fifties = value;
                    InvokePropertyChanged("Fifties");
                }
            }
        }

        private int hundreds = 0;

        /// <summary>
        /// Gets or sets the number of hundred bills in the cash register
        /// </summary>
        public int Hundreds
        {
            get => hundreds;

            set
            {
                if (hundreds == value || value < 0) return;
                else
                {
                    hundreds = value;
                    InvokePropertyChanged("Hundreds");
                }
            }
        }


    }


}
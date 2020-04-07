/* Author: Abdulkareem Alkhiary
 * Class: Money.cs 
 * Description: Handles money in register */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Handles the money in either register or customers hand
    /// </summary>
    public class Money
    {
        /// <summary>
        /// cash in register
        /// </summary>
        public static ModelView Register { get; private set; } = new ModelView();

        /// <summary>
        /// The cash given
        /// </summary>
        public Cash cash { get; private set; } = new Cash();

        public double Total { get; set; }

        /// <summary>
        /// calculate change
        /// </summary>
        /// <param name="total">Total amount required to complete transaction</param>
        /// <returns>String of bill/coin values to return back to customer</returns>
        public string TotalChange(double total)
        {
            Total = total;

            double totalChange = cash.Changetotal - total;

            Register.Pennies += cash.Pennies;
            Register.Nickels += cash.Nickels;
            Register.Dimes += cash.Dimes;
            Register.Quarters += cash.Quarters;
            Register.HalfDollars += cash.HalfDollars;
            Register.Dollars += cash.Dollars;
            Register.Ones += cash.Ones;
            Register.Twos += cash.Twos;
            Register.Fives += cash.Fives;
            Register.Tens += cash.Tens;
            Register.Twenties += cash.Twenties;
            Register.Fifties += cash.Fifties;
            Register.Hundreds += cash.Hundreds;


            StringBuilder changeAmounts = new StringBuilder();

            Register.Hundreds -=
                ChangeAmount(Register.Hundreds, 100.00, changeAmounts, ref totalChange, new string[] { "Hundred", "Hundreds" });
            Register.Fifties -=
                ChangeAmount(Register.Fifties, 50.00, changeAmounts, ref totalChange, new string[] { "Fifty", "Fifties" });
            Register.Twenties -=
                ChangeAmount(Register.Twenties, 20.00, changeAmounts, ref totalChange, new string[] { "Twenty", "Twenties" });
            Register.Tens -=
                ChangeAmount(Register.Tens, 10.00, changeAmounts, ref totalChange, new string[] { "Ten", "Tens" });
            Register.Fives -=
                ChangeAmount(Register.Fives, 5.00, changeAmounts, ref totalChange, new string[] { "Five", "Fives" });
            Register.Twos -=
                ChangeAmount(Register.Twos, 2.00, changeAmounts, ref totalChange, new string[] { "Two", "Twos" });
            Register.Ones -=
                ChangeAmount(Register.Ones, 1.00, changeAmounts, ref totalChange, new string[] { "One", "Ones" });
            Register.Dollars -=
                ChangeAmount(Register.Dollars, 1.00, changeAmounts, ref totalChange, new string[] { "Dollar Coin", "Dollar Coins" });
            Register.HalfDollars -=
                ChangeAmount(Register.HalfDollars, 0.50, changeAmounts, ref totalChange, new string[] { "Half-Dollar", "Half-Dollars" });
            Register.Quarters -=
                ChangeAmount(Register.Quarters, 0.25, changeAmounts, ref totalChange, new string[] { "Quarter", "Quarters" });
            Register.Dimes -=
                ChangeAmount(Register.Dimes, 0.10, changeAmounts, ref totalChange, new string[] { "Dime", "Dimes" });
            Register.Nickels -=
                ChangeAmount(Register.Nickels, 0.05, changeAmounts, ref totalChange, new string[] { "Nickel", "Nickels" });
            Register.Pennies -=
                ChangeAmount(Register.Pennies, 0.01, changeAmounts, ref totalChange, new string[] { "Penny", "Pennies" });

            if (totalChange >= 0.01) throw new InvalidOperationException(); //
            else return changeAmounts.ToString();
        }
        /// <summary>
        /// change to customer
        /// </summary>
        /// <param name="numberAvailable">Number of available coins or bills</param>
        /// <param name="valueOfDenomination">The worth of this denomination</param>
        /// <param name="changeAmounts">Change amounts to give</param>
        /// <param name="changeToGiveBack">Total cost reference</param>
        /// <param name="denominationName">An array of strings for single and multiple denomination types</param>
        /// <returns>Number of this denomination</returns>
        private int ChangeAmount(int numberOfChangeAvailable, double valueOfDenomination, StringBuilder changeAmounts, ref double changeToGiveBack, string[] denominationName)
        {
            int neededAmount = (int)Math.Round((changeToGiveBack / valueOfDenomination), MidpointRounding.ToZero);
            int specificNumber = (Math.Min(numberOfChangeAvailable, neededAmount));

            if (specificNumber == 1) changeAmounts.AppendLine(specificNumber + " " + denominationName[0]);
            if (specificNumber > 1) changeAmounts.AppendLine(specificNumber + " " + denominationName[1]);

            changeToGiveBack -= specificNumber * valueOfDenomination;
            return specificNumber;
        }
    }
}
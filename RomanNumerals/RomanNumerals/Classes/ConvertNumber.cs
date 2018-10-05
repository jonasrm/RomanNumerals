using RomanNumerals.CustomException;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RomanNumerals.Classes
{
    /// <summary>
    /// Convert Number Class
    /// </summary>
    public class ConvertNumber
    {
        private readonly Dictionary<int, string> _toRomanNumbers = new Dictionary<int, string>
        {
            {0, ""},
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"},
            {10, "X"},
            {20, "XX"},
            {30, "XXX"},
            {40, "XL"},
            {50, "L"},
            {60, "LX"},
            {70, "LXX"},
            {80, "LXXX"},
            {90, "XC"},
            {100, "C"},
            {200, "CC"},
            {300, "CCC"},
            {400, "CD"},
            {500, "D"},
            {600, "DC"},
            {700, "DCC"},
            {800, "DCCC"},
            {900, "CM"},
            {1000, "M"},
            {2000, "MM"},
            {3000, "MMM"}
        };

        /// <summary>
        /// Convert numeric value to roman numerals
        /// </summary>
        /// <param name="value">Integer value to convert in roman numerals</param>
        /// <returns></returns>
        public string IntToRomanNumeral(int value)
        {
            string result = string.Empty;

            try
            {
                if (value < 1 || value > 3000)
                    throw new InputValueException("Invalid number, insert value between 1 and 3000.");

                int multiplicator = 1;
                foreach (char item in value.ToString().Reverse())
                {
                    int key = int.Parse(item.ToString()) * multiplicator;
                    result = _toRomanNumbers[key] + result;
                    multiplicator *= 10;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }
    }
}

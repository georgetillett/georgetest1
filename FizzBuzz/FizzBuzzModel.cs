using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzModel
    {
        private const string FIZZ_IDENTIFIER = "Fizz";
        private const string BUZZ_IDENTIFIER = "Buzz";

        public List<string> FormatNumericList(int minimumValue, int maximumValue)
        {
            // Output variable
            List<string> list = new List<string>();

            // Iterate through the numeric values and apply the business rules
            for (int value = minimumValue; value <= maximumValue; value++)
            {
                list.Add(ApplyBusinessRules(value));
            }

            // Return the list
            return list;
        }

        private string ApplyBusinessRules(int value)
        {
            StringBuilder text = new StringBuilder();

            // Test for multiple of 3
            if (IsMultipleThree(value))
            {
                text.Append(FIZZ_IDENTIFIER);
            }

            // Test for multiple of 5
            if (IsMultipleFive(value))
            {
                text.Append(BUZZ_IDENTIFIER);
            }

            // Test for neither case
            if (text.Length == 0)
            {
                text.Append(value.ToString());
            }

            return text.ToString();
        }

        /// <summary>
        /// If the value is evenly divided by 3, then return TRUE.
        /// Otherwise, return FALSE
        /// </summary>
        public static bool IsMultipleThree(int value)
        {
            return value % 3 == 0;
        }

        /// <summary>
        /// If the value is evenly divided by 5, then return TRUE.
        /// Otherwise, return FALSE
        /// </summary>
        public static bool IsMultipleFive(int value)
        {
            return value % 5 == 0;
        }
    }
}

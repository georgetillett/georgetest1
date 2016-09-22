using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// EXERCISE:
    /// Create a C# console application. 
    /// The console application should write numbers from 1 to 100 to the screen. 
    /// However, when the number is a multiple of three, write “Fizz” instead of the number. 
    /// When the number is a multiple of 5, write “Buzz” instead of the number. 
    /// When the number is a multiple of both three and five, write “FizzBuzz” instead of the number.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create the list of strings to output
            List<string> list = new FizzBuzzModel().FormatNumericList(1, 100);

            // Write each string to the console
            foreach(string text in list)
            {
                Console.WriteLine(text);
            }

            // Stop the command window from closing
            Console.WriteLine();
            Console.WriteLine("Press the ANY key to continue.");
            Console.ReadLine();
        }
    }
}

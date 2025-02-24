using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // writing text to the Console Screen
            Console.WriteLine("Welcome \t \"to\" \nC#");

            // input from the keyboard 
            int num1=0, num2;

            Console.WriteLine("Enter 2 int number:");
            num1 = int.Parse( Console.ReadLine() ); // read until the end of the line
            num2 = Convert.ToInt32( Console.ReadLine());

            int sum = num1 + num2; // addition
            Console.WriteLine("Sum = " + sum);  // string concate
            Console.WriteLine($"Sum is {num1+num2}"); // placeholder: variable or expression

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03Ex02 {
    class Program {

        static void Main(string[] args) {

            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine("Now give me a number:");
            double firstNumber;
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            double secondNumber;
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of the firstNumber + secondNumber is: {firstNumber + secondNumber}");
            WriteLine("I think you're done...."); // I've used using static system.console which means I can access WriteLine without explicit namespace id
            Console.ReadKey();
            
        }

    }
}

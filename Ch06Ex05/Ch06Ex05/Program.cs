using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch06Ex05 {
    class Program {

        // we define a delegate with the same signature as the two functions we want to be able to use
        // rather than using 'static' to define a function, we simply use the delegate keyword instead.
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;

        // final test function
        static void PassAndExecuteDelegate(ProcessDelegate aProcess) {
            WriteLine($"This is executed from within another function: {aProcess(10,10)}");
        }
        
        static void Main(string[] args) {

            ProcessDelegate process; // declare a new variable of our delegate type - but dont initialise it yet - i.e. it doesn't actually contain an object yet
            WriteLine("Enter 2 numbers separated by a comma:");

            string input = ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = ToDouble(input.Substring(0, commaPos));
            double param2 = ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));

            WriteLine("Enter M to multiply or D to divide:");
            input = ReadLine().ToUpper();

            // here we create a new instance of delegate and pass it the function name that we want to use
            // think of this as saying what signature, or interface, the delegate must use, then we pass it a reference to the actual function as we initialise it.
            if (input == "M") {
                process = new ProcessDelegate(Multiply);
            } else {
                process = new ProcessDelegate(Divide);
            }

            // our new delegate object now has the same signature as our two functions, and when we call it, it's behaviour reflects that of the function specified at the point of initialisation.
            // even though delegates are considered variables (because their contents can change), they are treated like functions once initialised. 
            WriteLine($"Result: {process(param1, param2)}");

            //although we've called process, like a function, directly above, we could pass the instance (process) into another function and call it there instead - i.e.:
            PassAndExecuteDelegate(process);

            ReadKey();

        }
    }
}

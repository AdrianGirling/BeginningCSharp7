using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Arrays {
    class Program {
        static void Main(string[] args) {

            // can define arrays in a few ways, explicitly and implicity

            // explicitly define a multidimensional array of base type double, with 3 rows and 4 columns
            double[,] myArray = new double[3, 4];

            WriteLine("All elements in myArray empty array");
            foreach (double element in myArray) {
                WriteLine($"{element}");
            }

            // implicitly define the same size array, by using literal values to determine its size
            double[,] myOtherArray = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

            WriteLine("All elements in myOtherArray populated array");
            foreach (double element in myOtherArray) {
                WriteLine($"{element}");
            }

            WriteLine($"Element myOtherArray[0,0]: {myOtherArray[0, 0]}");
            WriteLine($"Element myOtherArray[0,1]: {myOtherArray[0, 1]}");
            WriteLine($"Element myOtherArray[0,2]: {myOtherArray[0, 2]}");
            WriteLine($"Element myOtherArray[0,3]: {myOtherArray[0, 3]}");
            WriteLine($"Element myOtherArray[1,0]: {myOtherArray[1, 0]}");
            WriteLine($"Element myOtherArray[1,1]: {myOtherArray[1, 1]}");
            WriteLine($"Element myOtherArray[1,2]: {myOtherArray[1, 2]}");
            WriteLine($"Element myOtherArray[1,3]: {myOtherArray[1, 3]}");

            ReadKey();

        }
    }
}

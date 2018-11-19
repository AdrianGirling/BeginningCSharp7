using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09Ex03 {

    class MyClass {
        public int val;
    }

    struct myStruct {
        public int val;
    }
    
    class Program {
        static void Main(string[] args) {

            MyClass objectA = new MyClass();
            MyClass objectB = objectA;
            MyClass objectC = objectB;
            objectA.val = 10;
            objectB.val = 20;
            objectB.val = 30;

            myStruct structA = new myStruct();
            myStruct structB = structA;
            structA.val = 40;
            structB.val = 50;

            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"objectC.val = {objectC.val}");
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");

            ReadKey();


        }
    }
}

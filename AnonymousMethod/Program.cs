using System;

namespace AnonymousMethod
{
    class Program
    {
        public delegate void Print(int value);

        public delegate int myDelegate(int value, int val);

        static void Main(string[] args)
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);

            myDelegate del = delegate (int a, int b) { 
                return a + b; 
            };

            Console.WriteLine(del(10, 10));

            int i = 10;

            Print prnt = delegate (int val) {
                //Anonymous methods can access variables defined in an outer function, but NOT ref or out paramete of the outer method 
                //It cannot have or access unsafe code
                //It cannot be used on the left side of the is operator.
                val += i;
                Console.WriteLine($"Anonymous method: {val}");
            };

            prnt(100);

            del += addNumbers;
            Console.WriteLine(multiplyNumbers(5, del(6, 9)));


        }

        public static int multiplyNumbers(int a, int b)
        {
            return a * b;
        }

        public static int addNumbers(int a, int b)
        {
            return a + b;
        }


    }
}

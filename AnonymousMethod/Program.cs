using System;

namespace AnonymousMethod
{
    class Program
    {
        public delegate void Print(int value);

        public delegate int Add(int value, int val);

        static void Main(string[] args)
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);

            Add sum = delegate (int a, int b) { 
                return a + b; 
            };

            Console.WriteLine(sum(10, 10));

            int i = 10;

            Print prnt = delegate (int val) {
                //Anonymous methods can access variables defined in an outer function, but NOT ref or out parameter of the outer method 
                val += i;
                Console.WriteLine($"Anonymous method: {val}");
            };

            prnt(100);
        }


    }
}

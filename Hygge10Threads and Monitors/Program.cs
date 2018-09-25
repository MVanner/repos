using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hygge10Threads_and_Monitors
{
    class Program
    {
        private const int ITERATIONS = 1000000;
        private static Int64 _number;
        public static Int64 Number { get { return _number; } set { _number = value; } }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            Number = 0;
            Thread adder = new Thread(Add);
            Thread subtractor = new Thread(Subtract);
            adder.Start();
            subtractor.Start();
            adder.Join();
            subtractor.Join();
            Console.Write($"Number: {Number}. \t\tPress any key...");
            Console.ReadKey();
        }

        private void Add()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Interlocked.Increment(ref Program._number);
            }
        }

        private void Subtract()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Interlocked.Decrement(ref Program._number);
            }
        }
    }

}

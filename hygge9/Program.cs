using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hygge9
{
    class Program
    {
        private object _key = new object();
        private double accum = 0.0;
        private const int WEATHERSTATIONS = 10;
        private const int MEASURES = 1000;
        private const double VALUE = 1.0;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            const double EXPECTED = WEATHERSTATIONS * MEASURES * VALUE;
            for (int i = 0; i < 10; i++)
            {
                accum = 0.0;
                double result = Measure();
                if (result != EXPECTED)
                {
                    Console.WriteLine("ERROR: " + (EXPECTED - result));
                }
               
            }
            Console.Write("Press a key ..."); Console.ReadKey();
        }

        private double Measure()
        {
            Thread[] threads = new Thread[WEATHERSTATIONS];
            for (int i = 0; i < WEATHERSTATIONS; i++)
            {
                threads[i] = new Thread(Sensor);
                threads[i].Start();
            }
            //Do not join until all threads are started
            for (int i = 0; i < WEATHERSTATIONS; i++)
            {
                threads[i].Join();
            }
            return accum;
        }

        private void Sensor()
        {
           
            for (int i = 0; i < MEASURES; i++)
            {
                lock (_key)
                {
                    double temp = accum;
                    Console.WriteLine(i);
                    //do some work 
                    Thread.Sleep(1);

                    accum = temp + VALUE;
                }
                
            }
        }
    }
}

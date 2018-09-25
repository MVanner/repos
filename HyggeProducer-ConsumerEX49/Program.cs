using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HyggeProducer_ConsumerEX49
{
    class Program
    {
        static Semaphore liftA = new Semaphore(10, 10);
        public static int _antalSkiløbereA = 30;
        public const int _køretidA = 100;
        public const int _kapacitetA = 10;
        static bool _up;
        public long ventetid;
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            //_reindearInStable = 0;
            _up = false;
            Thread[] threads = new Thread[_antalSkiløbereA];
            for (int i = 0; i < _antalSkiløbereA; i++)
            {
                threads[i] = new Thread(Lift) { Name = (i + 1).ToString() };
                threads[i].Start();
               // Console.WriteLine(threads[i].Name);
            }

            for (int i = 0; i < _antalSkiløbereA; i++)
            {
                threads[i].Join();
            }
            
        }

        
        private void Lift()
        {
            int i = 0;

            while (_up == false)
            {
                Stopwatch stopWatch = new Stopwatch();


                stopWatch.Start();


                liftA.WaitOne();


                stopWatch.Stop();


                ventetid = stopWatch.ElapsedMilliseconds;

                Console.WriteLine(Thread.CurrentThread.Name + " " + ventetid);
                Thread.Sleep(100);
                liftA.Release();
                i++;
                _up = true;
            }

            Random random = new Random();
            
            if (i == random.Next(5, 7))
            {

                Console.WriteLine("hygge");
                while (_up == true)
                {

                    Thread.Sleep(random.Next(100, 200));
                    _up = false;
                }
            }
            
        }

        public void Pist()
        {
            Random random = new Random();
            int i = 0;
           
            if (i == random.Next(5,7))
            {
                Console.WriteLine("hygge"); 
            }
            else if (_up == true)
            {

                Thread.Sleep(random.Next(100, 200));
                _up = false;
                i++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hygge11Threads_and_Semaphores
{
    class Program
    {
        static Semaphore Stable = new Semaphore(9, 9);
        static Semaphore Sleigh = new Semaphore(9, 9);
        public static int _reindearInStable;
        public const int _reindearCount = 9;
        public bool _gate;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void Run()
        {
            _reindearInStable = 0;
            _gate = true;
            Thread[] threads = new Thread[_reindearCount];
            for (int i = 0; i < _reindearCount; i++)
            {
                threads[i] = new Thread(Training) { Name = (i + 1).ToString() };
                threads[i].Start();
            }

            for (int i = 0; i < _reindearCount; i++)
            {
                threads[i].Join();
            }
        }

        public void EnterStable()
        {
            while (!_gate)
            {
                Thread.Sleep(100);
            }
            Interlocked.Increment(ref Program._reindearInStable);
            Console.WriteLine("Reindear number " + Thread.CurrentThread.Name + " entered the stable");
        }

        public void GoToSleigh()
        {
            Interlocked.Decrement(ref Program._reindearInStable);
            Console.WriteLine("Reindear number " + Thread.CurrentThread.Name + " went to sleigh");
        } 

        public void Training()
        {
            //for (int i = 0; i < 3; i++)
            //{
                
                Stable.WaitOne();
                EnterStable();
                Stable.Release(9);
                _gate = false;
                GoToSleigh();
                Sleigh.WaitOne();
                _gate = true;
                Thread.Sleep(100);
                
            //}


        }
    }
}

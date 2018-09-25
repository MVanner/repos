using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadOpgaveå
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread Lama = new Thread(() => 
            {
                string msg = Console.ReadLine();
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(msg + "1");
                }
            });
            Thread Del = new Thread(delegate () 
            {
                string msg = Console.ReadLine();
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(msg + "2");
                }
            });
            Thread Meth = new Thread(new ThreadStart(Method));

            Lama.Start();
            Del.Start();
            Meth.Start();
               
            

        }
        static void Method ()
        {
            string msg = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(msg + "3");
            }
        }
      

    }
}

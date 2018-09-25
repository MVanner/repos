using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 10;
            int myNumTwo = 20;

            if(myNum == myNumTwo)
            {
                Console.WriteLine("numbers are equal");
            }
            else if (myNumTwo != myNum)
            {
                Console.WriteLine("Numbers ar inequal");
            }
            Console.ReadLine();

            int MyNUM = 1;
            
            switch (MyNUM)
            {
                case 1:
                    Console.WriteLine("num is 1");
                    break;
                case 2:
                    Console.WriteLine("num is 2");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;



            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 9;

            string alsoNum = "0";

            var result = myNum + Convert.ToInt16(alsoNum);
            // Convert.ToInt16 konvertere string til int

            Console.WriteLine(result);

            Console.ReadLine();

            double myNumber = 786;

            string sentence = "My number is: " + myNumber.ToString();
            //myNumber.ToString() konvertere min double til en string
        }
    }
}

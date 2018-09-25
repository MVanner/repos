using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tre_på_stribe
{
    class Program
    {
        static void Main(string[] args)
        {
            int winWidth = (Console.WindowWidth / 2);

            Console.WriteLine(String.Format("{0,"+winWidth+"}", "Tre på Stribe"));
            Console.WriteLine("***********************");
            Console.WriteLine("    A) Nyt spil \n" +
            "    B) Exit");
            Console.WriteLine("***********************");
            string k;
            k = Console.ReadLine();

            

            if (k == "a")
            {
                Console.Clear();
                Game.NewGame();

            }
            if(k == "b")
            {
                Environment.Exit(0);    
            }

        }
    }
}

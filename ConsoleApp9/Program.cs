using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate double zoneCalc(double price);


namespace ConsoleApp9  
{
    public class zoneDelegates
    {
        //public static double calPrice = 0;
        public static double Zone1(double price)
        {
            return  price * 1.25;
            
        }

        public static double Zone2(double price)
        {
            return price * 1.12 + 25;

        }
        public static double Zone3(double price)
        {
            return price * 1.08;

        }
        public static double Zone4(double price)
        {
            return price * 1.04 + 25;

        }
        //public static double getPrice()
        //{
        //    return calPrice;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            zoneCalc zoneCalculator1 = zoneDelegates.Zone1;
            zoneCalc zoneCalculator2 = zoneDelegates.Zone2;
            zoneCalc zoneCalculator3 = zoneDelegates.Zone3;
            zoneCalc zoneCalculator4 = zoneDelegates.Zone4;
          
            Console.WriteLine("Vælg Zone (1-4)");
            int zone = Convert.ToInt32(Console.ReadLine());
            switch (zone)
            {
                case 1:
                    Console.WriteLine("skriv pris");
                    double zone1 = Double.Parse(Console.ReadLine());
                    double Zone11 = zoneCalculator1(zone1);
                    Console.WriteLine("Calculated price is {0}", Zone11);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("skriv pris");
                    double zone2 = Double.Parse(Console.ReadLine());
                    double Zone22 = zoneCalculator2(zone2);
                    Console.WriteLine("Calculated price is {0}", Zone22);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("skriv pris");
                    double zone3 = Double.Parse(Console.ReadLine());
                    double Zone33 = zoneCalculator3(zone3);
                    Console.WriteLine("Calculated price is {0}", Zone33);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("skriv pris");
                    double zone4 = Double.Parse(Console.ReadLine());
                    double Zone44 = zoneCalculator4(zone4);
                    Console.WriteLine("Calculated price is {0}", Zone44);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Vælg Zone (1-4)");
            Console.ReadKey();



            //zoneCalc zoneCalculator1 = zoneDelegates.Zone1;


            //double d = Double.Parse(Console.ReadLine());
            //double dd = zoneCalculator1(d);

            //Console.WriteLine("Calculated price is {0}", dd);
            //Console.ReadKey();

        }

        
    }
}
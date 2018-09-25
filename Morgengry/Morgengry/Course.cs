using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        public string ItemId { get; set; }
        public string Name = "";
        public int DurationInMinutes = 0;
        public double CourseHourValue = 825;

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, int Duration)
        {
            this.Name = name;
            this.DurationInMinutes = Duration;
        }

        public double GetValue()
        {
            double resultat = 0;
            int i = DurationInMinutes;
            while(i > 0)
            {
               resultat = resultat + CourseHourValue;
                i = i - 60;
            }
            return resultat;

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;
        }
    }
}

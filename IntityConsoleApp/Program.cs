using IntityConsoleApp.Entities;
using System;

namespace IntityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db= new ActorDbContext() )
            {
                //seed
                db.Actors.AddRange(new Actor { Name = "Hygge Peter", Age = 69, AcademyWinner = false },
                                   new Actor { Name = "Klamheden selv", AcademyWinner = true, Age = 42 });
                var count = db.SaveChanges();

                Console.WriteLine($"{count} Records added");

                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Name - {Actor.Name}, \t\t" + $"Age - {Actor.Age}, \t\t" + $"Academy Winner - {Actor.AcademyWinner}");

                }
                Console.ReadLine();
            }
        }
    }
}

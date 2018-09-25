using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morgengry
{
    public class ValuableRepository : IPersistable
    {
        List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string ItemId)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable.ItemId == ItemId)
                {
                    return valuable;
                }
            }
            return null;
        }
        public Double GetTotalValue()
        {
            double Value = 0;
            foreach (IValuable valuable in valuables)
            {
                Value += valuable.GetValue();
            }
            return Value;
        }
        public int Count()
        {
            return valuables.Count;
        }

        public void Save()
        {
            Save("ValuableRepository.txt");

        }

        public void Save(string filename)
        {
            StreamWriter SaveRepo = new StreamWriter(filename);
            foreach (IValuable x in valuables)
            {
                if(x is Amulet)
                {
                    Amulet amulet = (Amulet)x;
                    SaveRepo.WriteLine("Amulet;" + amulet.ItemId + ";" + amulet.Quality + ";" + amulet.Design);
                }
                else if (x is Book)
                {
                    Book books = (Book)x;

                    SaveRepo.WriteLine("BOG;" + books.ItemId + ";" + books.Title + ";" + books.Price);
                }   
            }
        }

        public void Load()
        {
            Load("ValuableRepository.txt");
        }

        public void Load(string filename)
        {
            StreamReader LoadRepo = new StreamReader(filename);
            string line = "";
            while (line != null)
            {
                line = LoadRepo.ReadLine();
                if ()
                AddValuable();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        public string Title = "";
        public double Price = 0;

        public Book(string ItemId)
        {
            this.ItemId = ItemId;
        }

        public Book(string ItemId, string Title)
        {
            this.ItemId = ItemId;
            this.Title = Title;
        }
        public Book(string ItemId, string Title, double Price)
        {
            this.ItemId = ItemId;
            this.Title = Title;
            this.Price = Price;
        }

        public override double GetValue()
        {
            return Price;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price;
        }
    }
}

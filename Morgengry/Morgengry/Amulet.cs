
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry 
{
        public enum Level 
        {
            low,
            medium,
            high
        };
    public class Amulet : Merchandise
    {
        public string Design = "";
        public Level Quality = Level.medium;

        public Amulet(string ItemId) 
        {
            this.ItemId = ItemId;
        }

        public Amulet(string ItemId, Level Quality) 
        {
            this.ItemId = ItemId;
            this.Quality = Quality;
        }
        public Amulet(string ItemId, Level Quality, string Design) 
        {
            this.ItemId = ItemId;
            this.Design = Design;
            this.Quality = Quality;
        }
        public override double GetValue()
        {
            if(Quality == Level.low)
            {
                return 12.5;
            }
            else if( Quality == Level.medium)
            {
                return 20.0;
            }
            else
            {
                return 27.5;
            }
             
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}

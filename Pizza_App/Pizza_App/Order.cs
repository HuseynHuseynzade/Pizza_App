using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class Order
    {
        public Pizza Pizza { get; set; }
        public int Number { get; set; }
        public decimal TotalPrice { get; set; }
        public override string ToString()
        {
            string spr = " ";
            spr += Pizza.Measure.Name + " , ";
            spr += Pizza.Name + " , ";
            spr += Pizza.Outside.Name + " , ";
            foreach (string mlz in Pizza.Products)
            {
                spr += string.Format("{0} ,", mlz);
            }

            spr = spr.Remove(spr.Length - 1, 1);
            spr += string.Format("{0} * {1} = {2}", Number, Pizza.TotalCount, Number * Pizza.TotalCount);
            return spr;


        }
    }
}

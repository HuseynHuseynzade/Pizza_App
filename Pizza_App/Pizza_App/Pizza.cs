using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class Pizza
    {
        public String Name { get; set; }
        public decimal Price { get; set; }
        public Measure Measure { get; set; }
        public Outside Outside { get; set; }
        public List<string> Products { get; set; }

        //hesablama edecek ve geriye deyer gonderecek
        public decimal TotalCount
        {
            get
            {
                decimal TotalCount = 0;
                TotalCount = Price * (decimal)Measure.Multiplication;
                TotalCount += Outside.Extraprice;
                return TotalCount;
            }
        }

        //ebat daki override ni burdada tekrarlayiriq
        public override string ToString()
        {
            return Name;
        }
    
    }
}

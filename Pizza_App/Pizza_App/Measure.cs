using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class Measure
    {
        public string Name { get; set; }
        public double Multiplication { get; set; }


        //Measure icerisinde adlarin kicik orta boyuk maxi cixmagi uchun tostringi override edib return adi;
        //yaziriq ve ya ele ede bilerikki qiymetlerde gorsensin
        // 
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Multiplication);
        }
    }
}

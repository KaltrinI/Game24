using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game24
{   [Serializable]
    public class BCHigh
    {

        public string Ime { get; set; }
        public double time { get; set; }

        public BCHigh(string i, double t) {
            Ime = i;
            time = t;
        
        }

        public override string ToString()
        {
            return String.Format("{0} {1:0.000}", Ime, time);
        }
    }
}

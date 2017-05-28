using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game24
{   [Serializable]
    public class TAHigh
    {
        string Ime { get; set; }
        public int correct { get; set; }

        public TAHigh(string i, int c) {
            Ime = i;
            correct = c;
        
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Ime, correct);
        }
    }
}

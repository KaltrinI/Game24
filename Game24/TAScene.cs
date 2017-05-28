using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game24
{   [Serializable]
    public class TAScene
    {
        public List<TAHigh> lista {get;set;}

        public TAScene() {

            lista = new List<TAHigh>();
        }


        public TAHigh worst()
        {
            return lista[lista.Count - 1];
        }

    }
}

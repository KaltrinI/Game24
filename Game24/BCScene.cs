using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game24
{   [Serializable]
    public class BCScene
    {

    public List<BCHigh> lista { get; set; }
    public BCScene() {

        lista = new List<BCHigh>();
    }


    public BCHigh worst()
    {
        return lista[lista.Count - 1];    
    }



   
    }
}

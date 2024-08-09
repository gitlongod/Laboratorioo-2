using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Suite: Habitacion
    {
        public Suite(int numero, double price, string availability, string cliente,string type): base(numero, price, availability, cliente, type) 
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    public class Habitacion_simple : Habitacion
    {
        public Habitacion_simple(int numero,double price,string availability, string cliente) : base(numero,price, availability,cliente) 
        {
            
        }

    }
}

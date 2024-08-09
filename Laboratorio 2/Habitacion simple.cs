using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio_2
{
    
    public class Habitacion_simple : Habitacion
    {
        public int numBeds { get; set; }

        public Habitacion_simple(int numero, double price, string availability, string cliente, string type) : base(numero, price, availability, cliente, type)
        {

        }
        

        
    }
}

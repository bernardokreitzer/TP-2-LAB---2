using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]
    class Habitacion : Propiedad
    { 
        public Habitacion(string nombre, int numero, string propiedad) : base(nombre, numero, propiedad)
        {

        }
    }
}

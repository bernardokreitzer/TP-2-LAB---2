using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TP_2_LAB___2
{
    [Serializable]
    class Propiedad
    {
        private string direccion;
        private int numeroPropiedad;

        public Propiedad(string dir, int numero)
        {
            direccion = dir;
            numeroPropiedad = numero;
        }

        public string Direccion
        {
            get { return direccion; }
             set{ direccion = value; } 
        }

        public int Numero 
        { 
            get { return numeroPropiedad; }
            set { numeroPropiedad = value; }

        }
    }
}

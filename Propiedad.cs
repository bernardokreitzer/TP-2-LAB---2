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
        protected double precioBase;
        protected string tipoPropiedad;
        private enum tipoServicio { Cochera, Pileta, WIFI, Limpieza, Desayuno, Mascotas };
        private bool[] servicios;
        private List<string> fotos;

        public Propiedad(string dir, int numero, string propiedad)
        {
            direccion = dir;
            numeroPropiedad = numero;
            tipoPropiedad = propiedad;
            fotos = new List<string>();
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

        public string TipoPropiedad 
        {
            get { return tipoPropiedad; }
            set { tipoPropiedad = value; }

        }

        public void AgregarFoto(string unaFoto)
        {
            fotos.Add(unaFoto);
        }
    }
}

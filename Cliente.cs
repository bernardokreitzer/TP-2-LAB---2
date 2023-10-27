using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]

    class Cliente : IComparable
    {
        private string nombreCliente;
        private int dniCliente;
        private string direccionCliente;

        public Cliente(string nom, int dni, string direccion)
        {
            nombreCliente = nom;
            dniCliente = dni;
            direccionCliente = direccion;
        }

        public string Nombre {get {return nombreCliente ;} }

        public string Direccion { get { return direccionCliente; } }

        public int Dni { get { return dniCliente; } }


        public int CompareTo(object obj)
        {
            return this.nombreCliente.CompareTo(((Cliente)obj).nombreCliente);
        }
    }
}

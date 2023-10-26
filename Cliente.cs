﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]

    class Cliente: IComparable
    {
        private string nombreCliente;
        private int dniCliente;
        private string direccionCliente;

        public Cliente (string nom, int dni, string direccion)
        {
            nombreCliente = nom;
            dniCliente = dni;
            direccionCliente = direccion;
        }

        public int CompareTo(object obj)
        {
            return this.nombreCliente.CompareTo(((Cliente)obj).nombreCliente);
        }
    }
}
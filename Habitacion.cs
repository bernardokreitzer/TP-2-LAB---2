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
        private int cantidadEstrella;
        private int tipoHabitacion;
        double precioFinal = 0;
        public Habitacion(string nombre, int numero, string propiedad) : base(nombre, numero, propiedad)
        {

        }
        public Habitacion(double precioBase, string direccion, int numeroPropiedad, string tipoPropiedad, string localidad, int cantidadEstrella)
            : base(precioBase, direccion, numeroPropiedad, tipoPropiedad, localidad)
        {
            this.cantidadEstrella = cantidadEstrella;
        }
        public int CantidadEstrella
        {
            get { return cantidadEstrella; }
        }
        public int TipoHabitacion
        {
            get { return tipoHabitacion; }
        }
        public override double CalcularCosto(int dias)
        {

            if (cantidadEstrella == 2 && tipoHabitacion == 1)
            {
                precioFinal = precioBase * dias;
            }
            if (cantidadEstrella == 2 && tipoHabitacion == 2)
            {
                precioFinal = (precioBase * dias) * 0.8;
            }
            if (cantidadEstrella == 2 && tipoHabitacion == 3)
            {
                precioFinal = (precioBase * dias) * 1.5;
            }

            //para 3 estrellas
            if (cantidadEstrella == 3 && tipoHabitacion == 1)
            {
                precioFinal = (precioBase * dias) + ((precioBase * dias) * 0.4);
            }

            if (cantidadEstrella == 3 && tipoHabitacion == 2)
            {
                precioFinal = ((precioBase * dias) + ((precioBase * dias) * 0.4) * 0.8);
            }

            if (cantidadEstrella == 3 && tipoHabitacion == 3)
            {
                precioFinal = ((precioBase * dias) + ((precioBase * dias) * 0.4) * 1.5);
            }

            return (precioFinal + (precioFinal * 0.03));
        }
    }
}

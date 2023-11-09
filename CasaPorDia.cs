using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]
    class CasaPorDia : Propiedad
    {
        private int cantidadDeHabitaciones;
        public int cantidadDeDias;
        public int diasMinimo;
        public double costo;
        //public double tarifaBase;

        public CasaPorDia(string nombre, int numero, string TipoPropiedad) : base(nombre, numero, TipoPropiedad)
        {

        }
        public CasaPorDia(double precioBase, string direccion, string nombrePropiedad, int numeroPropiedad, string tipoPropiedad, string localidad, int _cantidadHabitaciones)
            : base(precioBase, direccion, numeroPropiedad, tipoPropiedad, localidad)
        {
            cantidadDeHabitaciones = _cantidadHabitaciones;
            //cantidadDeDias = _cantidadDeDias;
            //diasMinimo = _diasMinimo;
        }

        public int CantidadDeHabitaciones
        {
            get { return cantidadDeHabitaciones; }
            set { cantidadDeHabitaciones = value; }
        }

        public int DiasMinimo
        {
            get { return diasMinimo; }
            set { diasMinimo = value; }
        }

        public int CantidadDeDias
        {
            get { return cantidadDeDias; }
            set { cantidadDeDias = value; }
        }

        public override double CalcularCosto(int dias)
        {
            int dif;
            if (dias > diasMinimo)
            {
                dif = dias - diasMinimo;
                costo = precioBase - (0.1 * dif);
            }
            else
            {
                costo = precioBase;
            }
            return costo*dias;
        }

    }
}

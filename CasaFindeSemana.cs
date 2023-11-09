using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]
    class CasaFindeSemana : CasaPorDia
    {
        public CasaFindeSemana(string nombre, int numero, string tipoPropiedad)
            : base(nombre, numero, tipoPropiedad)
        {

        }
        public CasaFindeSemana(double precioBase, string direccion, string nombrePropiedad, int numeroPropiedad, string tipoPropiedad, string localidad, int cantidadHabitaciones)
            : base(precioBase, direccion, nombrePropiedad, numeroPropiedad, tipoPropiedad, localidad, cantidadHabitaciones)
        {

        }

        public override double CalcularCosto(int dias)
        {
            return costo = precioBase * 3;
        }
    }
}

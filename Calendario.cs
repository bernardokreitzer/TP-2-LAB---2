using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    internal class Calendario
    {
        private int[,] dias;
        private int dimension = 100;
        int diasemana;
        int diasTotales1, diasTotales2, diasTotales3;
        int mes1, mes2, mes3;
        DateTime fecha;

        public Calendario(int mes, int año)
        {
            CrearCuadricula(mes, año);
        }
        public void CrearCuadricula(int mes, int año)
        {
            mes1 = mes;
            mes2 = mes + 1;
            mes3 = mes + 2;
            dias = new int[dimension, 3];
            fecha = new DateTime(año, mes, 1);
            diasemana = (int)fecha.DayOfWeek;
            diasTotales1 = DateTime.DaysInMonth(año, mes1);
            if (mes2 > 12)
                diasTotales2 = DateTime.DaysInMonth(año + 1, mes2 - 12);
            else
                diasTotales2 = DateTime.DaysInMonth(año, mes2);
            if (mes3 > 12)
                diasTotales3 = DateTime.DaysInMonth(año + 1, mes3 - 12);
            else
                diasTotales3 = DateTime.DaysInMonth(año, mes3);

            for (int d = 0; d < diasTotales1; d++)
            {
                dias[diasemana + d, 0] = d + 1;
                dias[diasemana + d, 2] = mes1;
            }
            for (int d = 0; d < diasTotales2; d++)
            {
                dias[diasemana + diasTotales1 + d, 0] = d + 1;
                dias[diasemana + diasTotales1 + d, 2] = mes2;
            }
            for (int d = 0; d < diasTotales3; d++)
            {
                dias[diasemana + diasTotales1 + diasTotales2 + d, 0] = d + 1;
                dias[diasemana + diasTotales1 + diasTotales2 + d, 2] = mes3;
            }
        }
        public bool Reservar(int dia, int mes, int cantidad)
        {
            int inicial = 0;
            bool correcto = true;
            int dimension = dias.GetLength(0);
            int[,] aux = new int[dimension, 3];
            Array.Copy(dias, aux, dimension * 3);
            while (!(dias[inicial, 2] == mes && dias[inicial, 0] == dia))
                inicial++;

            for (int d = inicial; d < cantidad + inicial; d++)
            {
                if (aux[d, 1] == 0) aux[d, 1] = 1;
                else correcto = false;
            }
            if (correcto)
            {
                Array.Copy(aux, dias, dimension * 3);
                Array.Clear(aux, 0, dimension * 3);
            }
            return correcto;
        }

        public int[,] Dias
        {
            get { return dias; }
        }
    }
}

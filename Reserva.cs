using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]
    class Reserva
    {
        private string tipo;
        private DateTime fechaReserva;
        private DateTime fechaCheckIn;
        private DateTime fechaCheckOut;
        private int cantidadDeDias;
        private Propiedad alojamiento;
        private Cliente nuevoCliente;


        private string nombre;
        private string direccion;
        private string localidad;
        private double precio;
        private int plazas;

        public Reserva (DateTime checkIn, DateTime checkOut, Propiedad alojamiento, Cliente unCliente)
        {
            fechaReserva = DateTime.Now.Date;
            fechaCheckIn = checkIn;
            fechaCheckOut = checkOut;
            TimeSpan cantDias = fechaCheckOut - fechaCheckIn;
            //TimeSpan diferencia = fechaFin - fechaInicio;


            this.alojamiento = alojamiento;
            nuevoCliente = unCliente;
        }
        public DateTime FechaReserva { get; }
        public DateTime FechaCheckin { get; }

        public int CantDias { get; }

        public Propiedad Alojamiento { get{ return alojamiento; } }
        public Cliente NuevoCliente { get { return nuevoCliente; } }




    }
}

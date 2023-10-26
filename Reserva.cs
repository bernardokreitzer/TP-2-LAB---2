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
        private Propiedad alojamiento;


        private string nombre;
        private string direccion;
        private string localidad;
        private double precio;
        private int plazas;

        public Reserva (DateTime checkIn, DateTime checkOut, Propiedad alojamiento)
        {
            fechaReserva = DateTime.Now.Date;
            fechaCheckIn = checkIn;
            fechaCheckOut = checkOut;
            this.alojamiento = alojamiento;
        }
        public DateTime FechaReserva { get; }
        public DateTime FechaCheckin { get; }
        public Propiedad Alojamiento { get{ return alojamiento; } }




    }
}

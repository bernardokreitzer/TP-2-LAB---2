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
        private double precioFinal;
        private int plazas;

        public Reserva (DateTime checkIn, int cantidad, Propiedad alojamiento, Cliente unCliente)
        {
            fechaReserva = DateTime.Now.Date;
            fechaCheckIn = checkIn;
            cantidadDeDias = cantidad;
            fechaCheckOut = fechaCheckIn.AddDays(cantidadDeDias);
            
            precioFinal = cantidadDeDias * 300;

            this.alojamiento = alojamiento;
            nuevoCliente = unCliente;
        }
        public DateTime FechaReserva { get { return fechaReserva; } }
        public DateTime FechaCheckin { get { return fechaCheckIn; } }
        public DateTime FechaCheckOut { get { return fechaCheckOut; } }

        public int CantidadDeDias { get { return cantidadDeDias; } }

        public double PrecioFinal { get { return precioFinal; } }

        public Propiedad Alojamiento { get{ return alojamiento; } }
        public Cliente NuevoCliente { get { return nuevoCliente; } }




    }
}

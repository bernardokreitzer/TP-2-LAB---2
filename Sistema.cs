using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_2_LAB___2
{
    [Serializable]
    class Sistema
    {
        protected List<Reserva> reservas;
        private double precioBase;
        private List<Cliente> clientes;
        private ArrayList propiedades;
        private List<Propiedad> propiedades2;

        public Sistema(double precioBase)
        {
            reservas = new List<Reserva>();
            this.precioBase = precioBase;
            propiedades = new ArrayList();
            propiedades2 = new List<Propiedad>();
        }

        public void AgregarCliente(Cliente unCliente)
        {
            clientes.Add(unCliente);
        }

        public void  ModificarPropiedad(int indice, string direccion, int numeroPropiedad )
        {
            propiedades2[indice].Direccion = direccion;
            propiedades2[indice].Numero = numeroPropiedad;
            
                }

        public int cantLista()
        {
            return propiedades2.Count;
        }

        public Propiedad BuscarPropiedad(int indice)
        {
            return propiedades2[indice];
        }

        public void AgregarPropiedades(Propiedad unaPropiedad)
        {
            propiedades2.Add(unaPropiedad);
        }

        public List<Propiedad> ListarPropiedades()
        {
            return propiedades2;
        }

        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public void BorrarPropiedad(int indice)
        {
            propiedades2.RemoveAt(indice);
        }


        //public  Propiedad  ListarPropiedades
        //{
        //     get {return propiedades; }
        //}

        public void AgregarReserva(DateTime fechaInicio, DateTime fechaFin, int totDias, Propiedad alojamiento)
        {
            reservas.Add(new Reserva(fechaInicio, fechaFin, alojamiento));
        }

        public void ModificarReserva()
        {

        }

        public void BorrarReserva()
        {

        }


    }
}

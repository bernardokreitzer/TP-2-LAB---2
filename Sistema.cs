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
        private List<Propiedad> propiedades2;
        private ArrayList propiedades;

        public Sistema(double precioBase)
        {
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
            this.precioBase = precioBase;
            propiedades = new ArrayList();
            propiedades2 = new List<Propiedad>();
        }

        public void AgregarCliente(string nom, int dni, string direccion)
        {        
            clientes.Add(new Cliente(nom, dni, direccion));
        }

        public List<Cliente> ListarClientes()
        {
            return clientes;
        }

        public Cliente BuscarCliente(int indice)
        {
            return clientes[indice];
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

        public void AgregarReserva(DateTime fechaInicio, DateTime fechaFin, int totDias, Propiedad alojamiento, Cliente unCliente)
        {
            reservas.Add(new Reserva(fechaInicio, fechaFin, alojamiento, unCliente));
        }

        public void ModificarReserva()
        {

        }

        public void BorrarReserva()
        {

        }


    }
}

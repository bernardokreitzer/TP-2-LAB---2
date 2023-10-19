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
        protected ArrayList reservas;
        private double precioBase;
        private Cliente[] clientes;
        private ArrayList propiedades;

        public Sistema(double precioBase)
        {
            reservas = new ArrayList();
            this.precioBase = precioBase;
            propiedades = new ArrayList();
        }

        public void AgregarCliente()
        {

        }

        public void  ModificarPropiedad(int indice, string direccion, int numeroPropiedad )
        {
            
        }

        public Propiedad BuscarPropiedad(int indice)
        {
            return (Propiedad)propiedades[indice];
        }

        public void AgregarPropiedades(Propiedad unaPropiedad)
        {
            propiedades.Add(unaPropiedad);
        }

        public  ArrayList ListarPropiedades()
        {
            return propiedades;
        }


        //public  Propiedad  ListarPropiedades
        //{
        //     get {return propiedades; }
        //}

        public void ModificarReserva()
        {

        }

        public void BorrarReserva()
        {

        }


    }
}

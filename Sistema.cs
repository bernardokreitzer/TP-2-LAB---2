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
        private List<Propiedad> propiedades2;

        public Sistema(double precioBase)
        {
            reservas = new ArrayList();
            this.precioBase = precioBase;
            propiedades = new ArrayList();
            propiedades2 = new List<Propiedad>();
        }

        public void AgregarCliente()
        {

        }

        public void  ModificarPropiedad(int indice, string direccion, int numeroPropiedad )
        {
            propiedades2[indice].Direccion = direccion;
            propiedades2[indice].Numero = numeroPropiedad;
            
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

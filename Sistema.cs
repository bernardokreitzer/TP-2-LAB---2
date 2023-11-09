using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private List<Propiedad> propiedades;

        public Sistema(double precioBase)
        {
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
            this.precioBase = precioBase;
            propiedades = new List<Propiedad>();
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
            propiedades[indice].Direccion = direccion;
            propiedades[indice].Numero = numeroPropiedad;
            
        }

        public int cantLista()
        {
            return propiedades.Count;
        }

        public Propiedad BuscarPropiedad(int indice)
        {
            return propiedades[indice];
        }

        public void AgregarPropiedades(Propiedad unaPropiedad)
        {
            propiedades.Add(unaPropiedad);
        }

        public List<Propiedad> ListarPropiedades()
        {
            return propiedades;
        }

        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public void BorrarPropiedad(int indice)
        {
            propiedades.RemoveAt(indice);
        }

        public void AgregarReserva(DateTime fechaInicio, int totDias, Propiedad alojamiento, Cliente unCliente)
        {
            reservas.Add(new Reserva(fechaInicio, totDias, alojamiento, unCliente));
        }

        public void ModificarReserva()
        {

        }

        public void BorrarReserva()
        {

        }

        public void ImportarReservas(string ruta)
        {
            FileStream archivo = null;
            StreamReader sr = null;
            string renglon;
            string[] datos;
            try
            {
                archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);
                while (!sr.EndOfStream)
                {
                    renglon = sr.ReadLine();
                    datos = renglon.Split(';');
                    //Procesar los datos
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al importar reservas: " + ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (archivo != null) archivo.Close();
            }
        }
        public void ExportarReservas(string ruta)
        {
            FileStream archivo = null;
            StreamWriter sw = null;
            try
            {
                archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(archivo);
                foreach (Reserva r in reservas)
                {
                    sw.WriteLine(r.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al exportar reservas: " + ex.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (archivo != null) archivo.Close();
            }
        }
    }
}

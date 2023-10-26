using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Globalization;

namespace TP_2_LAB___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sistema miSistema;
        Propiedad nuevoAlojamiento;
        double precioBase;

        protected ArrayList alojamientos = new ArrayList();




        private void ListarAlojamientos() 
        {
            lBoxAlojamientos.Items.Clear();
            foreach (Propiedad p in miSistema.ListarPropiedades())
            {
                lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero + " " + p.TipoPropiedad);
            }
        }

        private void btnAltaAlojamiento_Click(object sender, EventArgs e)
        {
            FCargaAlojamientos vCargaAlojamiento = new FCargaAlojamientos();

            if (vCargaAlojamiento.ShowDialog() == DialogResult.OK)
            {
                string direccion = vCargaAlojamiento.tbDireccion.Text;
                int numeroPropiedad = Convert.ToInt32(vCargaAlojamiento.tbNroPropiedad.Text);
                string tipoAlojamiento = vCargaAlojamiento.cbTipoAlojamiento.Text;

                miSistema.AgregarPropiedades(new Propiedad(direccion, numeroPropiedad, tipoAlojamiento));
                //   alojamientos.Add();
                ListarAlojamientos();
            }
            vCargaAlojamiento.Dispose();
        }

        private void Deserializar()
        {
            // Proceso De Serializar

            // 1. Crear Stream
           // FileStream miStream = new FileStream("C:/Users/alexx/Documents/alojamientos.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            // 2.- Crear Formateador
           // BinaryFormatter formateador = new BinaryFormatter();

            // 3.- DeSerialiar
            //nuevoAlojamiento = (Propiedad)formateador.Deserialize(miStream);
            //alojamientos[0] = nuevoAlojamiento;


            // 4.- Cerrar Stream
            //miStream.Close();
        }

        private void Serializar()
        {
            // Proceso Serializar

            // 1. Crear Stream
            FileStream miStream = new FileStream("C:/Users/alexx/Documents/alojamientos.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            // 2.- Crear Formateador
            BinaryFormatter formateador = new BinaryFormatter();

            // 3.- Serialiar
            formateador.Serialize(miStream, alojamientos[0]);
            formateador.Serialize(miStream, alojamientos[1]);

            // 4.- Cerrar Stream
            miStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //VENTANA INICIAL
            FPrecioBase vPrecioBase = new FPrecioBase();

            if (vPrecioBase.ShowDialog() == DialogResult.OK)
            {
                 precioBase = Convert.ToDouble(vPrecioBase.tbPrecioBase.Text);
                miSistema = new Sistema(precioBase);
                MessageBox.Show($"Precio base: {precioBase} ingresado correctamente");
            }

            else
            {
                MessageBox.Show("Cancelado por usuario");
            }      
            miSistema.AgregarPropiedades(new Propiedad("Colon 236", 20, "Casa Por Dia"));
            miSistema.AgregarPropiedades(new Propiedad("San Juan 555", 30, "Casa Por Dia"));

            //  alojamientos.Add(new Propiedad("San Juan 555", 30));


            //  Deserializar();

            ListarAlojamientos();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

            FCargaAlojamientos fModificarAlojamiento = new FCargaAlojamientos();
            int itemSeleccionado = lBoxAlojamientos.SelectedIndex;
            int totalPropiedades = miSistema.cantLista();
            try  
            {
                fModificarAlojamiento.tbDireccion.Text = miSistema.BuscarPropiedad(itemSeleccionado).Direccion;
                fModificarAlojamiento.tbNroPropiedad.Text = miSistema.BuscarPropiedad(itemSeleccionado).Numero.ToString();
                fModificarAlojamiento.cbTipoAlojamiento.Text = miSistema.BuscarPropiedad(itemSeleccionado).TipoPropiedad;

                int numeroPropiedad;

                if (fModificarAlojamiento.ShowDialog() == DialogResult.OK)
                {
                    string direccion = fModificarAlojamiento.tbDireccion.Text;
                    numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);

                    //  ((Propiedad)alojamientos[itemSeleccionado]).Direccion = direccion;
                    // ((Propiedad)alojamientos[itemSeleccionado]).Numero = numeroPropiedad;

                    miSistema.ModificarPropiedad(itemSeleccionado, direccion, numeroPropiedad);
                    //alojamientos.Add(new Propiedad(direccion, numeroPropiedad));
                    ListarAlojamientos();
                }
            }

            catch (ArgumentOutOfRangeException  ex)
            {
                // Manejo de la excepción
                MessageBox.Show("Debe seleccionar un item de la lista" );
            }

            //fModificarAlojamiento.tbDireccion.Text = "hola";
            //fModificarAlojamiento.tbDireccion.Text = ((Propiedad)alojamientos[itemSeleccionado]).Direccion;
            //fModificarAlojamiento.tbNroPropiedad.Text = ((Propiedad)alojamientos[itemSeleccionado]).Numero.ToString();



            //int numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);
            
            //string direccion = vCargaAlojamiento.tbDireccion.Text;
            //int numeroPropiedad = Convert.ToInt32(vCargaAlojamiento.tbNroPropiedad.Text);
        }

        private void btnAltaReservas_Click(object sender, EventArgs e)
        {
            FAltaReservas vReservas = new FAltaReservas();
            //string[] datos2 = miSistema.ListarPropiedades().ToArray();
            string[] datos = { "Opción 1", "Opción 2", "Opción 3", "Opción 4" };

            foreach(Propiedad p in miSistema.ListarPropiedades())
            {
                vReservas.cbAlojamientos.Items.Add(p.Direccion);

            }

           // vReservas.cbAlojamientos.Items.AddRange(datos);

            if (vReservas.ShowDialog() == DialogResult.OK)
            {

                DateTime fechaInicio = vReservas.dateTimePicker1.Value;
                DateTime fechaFin = vReservas.dateTimePicker2.Value;

                TimeSpan diferencia = fechaFin - fechaInicio;
                int diasDiferencia = diferencia.Days;
                int alojamientoSeleccionadoindice = vReservas.cbAlojamientos.SelectedIndex;
                Propiedad alojamientoSeleccionado = miSistema.BuscarPropiedad(alojamientoSeleccionadoindice);

                MessageBox.Show($"Fecha de inicio: {fechaInicio}\nFecha de fin: {fechaFin}\n Total Dias: { diasDiferencia}\n Lugar: {alojamientoSeleccionado.Direccion}");

                miSistema.AgregarReserva(fechaInicio, fechaFin, diasDiferencia, alojamientoSeleccionado);
                int cantreservas = 1;
                lbReservas.Items.Clear();
                foreach(Reserva r in miSistema.ListarReservas())
                {                
                    lbReservas.Items.Add(cantreservas.ToString("00")  +" - Reserva hecha el: " +  r.FechaCheckin.ToString("dd-MM-yyyy") + r.Alojamiento.Direccion);
                    //lbReservas.Items.Add(r.FechaCheckin.ToString("dddd", new CultureInfo("es-ES")));
                    cantreservas++;
                }
            
            
            }
        }

        private void BorrarAlojamiento_click(object sender, EventArgs e)
        {            // Borrar propiedad 

            try
            {
                int itemSeleccionado = lBoxAlojamientos.SelectedIndex;
                string propiedadSeleccionada = miSistema.BuscarPropiedad(itemSeleccionado).Direccion;

                DialogResult result = MessageBox.Show($"La propiedad {propiedadSeleccionada} sera borrada\n¿Desea confirmar el cambio?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // Aquí puedes poner el código para confirmar el cambio.
                    MessageBox.Show("Cambio confirmado");
                    miSistema.BorrarPropiedad(itemSeleccionado);
                }
                else
                {
                    // Aquí puedes poner el código para cancelar el cambio.
                    //MessageBox.Show("Cambio cancelado");
                }
                ListarAlojamientos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un item de la lista");
            }
            
        }
    }
}

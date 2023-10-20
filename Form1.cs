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
                lBoxAlojamientos.Items.Clear();
                foreach (Propiedad p in miSistema.ListarPropiedades())
                {
                    lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero + " " + p.TipoPropiedad );
                }

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

            lBoxAlojamientos.Items.Clear();
            foreach(Propiedad p in miSistema.ListarPropiedades())
            {
                lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero + " " + p.TipoPropiedad);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FCargaAlojamientos fModificarAlojamiento = new FCargaAlojamientos();
            int itemSeleccionado = lBoxAlojamientos.SelectedIndex;

            //fModificarAlojamiento.tbDireccion.Text = "hola";

            //fModificarAlojamiento.tbDireccion.Text = ((Propiedad)alojamientos[itemSeleccionado]).Direccion;
            //fModificarAlojamiento.tbNroPropiedad.Text = ((Propiedad)alojamientos[itemSeleccionado]).Numero.ToString();

            fModificarAlojamiento.tbDireccion.Text = miSistema.BuscarPropiedad(itemSeleccionado).Direccion;
            fModificarAlojamiento.tbNroPropiedad.Text = miSistema.BuscarPropiedad(itemSeleccionado).Numero.ToString();

            int numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);

            if (fModificarAlojamiento.ShowDialog() == DialogResult.OK)
            {
                string direccion = fModificarAlojamiento.tbDireccion.Text;
                numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);



              //  ((Propiedad)alojamientos[itemSeleccionado]).Direccion = direccion;
              //  ((Propiedad)alojamientos[itemSeleccionado]).Numero = numeroPropiedad;

                miSistema.ModificarPropiedad(itemSeleccionado, direccion, numeroPropiedad);

                

                //alojamientos.Add(new Propiedad(direccion, numeroPropiedad));
                this.lBoxAlojamientos.Items.Clear();
                foreach (Propiedad p in miSistema.ListarPropiedades())
                {
                    lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero);
                }

            }

            //string direccion = vCargaAlojamiento.tbDireccion.Text;
            //int numeroPropiedad = Convert.ToInt32(vCargaAlojamiento.tbNroPropiedad.Text);



        }
    }
}

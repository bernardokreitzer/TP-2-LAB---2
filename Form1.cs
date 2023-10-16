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

namespace TP_2_LAB___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Propiedad nuevoAlojamiento;

        protected ArrayList alojamientos = new ArrayList();

        private void btnAltaAlojamiento_Click(object sender, EventArgs e)
        {
            FCargaAlojamientos vCargaAlojamiento = new FCargaAlojamientos();

            if (vCargaAlojamiento.ShowDialog() == DialogResult.OK)
            {
                string direccion = vCargaAlojamiento.tbDireccion.Text;
                int numeroPropiedad = Convert.ToInt32(vCargaAlojamiento.tbNroPropiedad.Text);

                alojamientos.Add(new Propiedad(direccion, numeroPropiedad));
                lBoxAlojamientos.Items.Clear();
                foreach (Propiedad p in alojamientos)
                {
                    lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero);
                }

            }
            vCargaAlojamiento.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            alojamientos.Add(new Propiedad("Colon 236", 20));

            alojamientos.Add(new Propiedad("San Juan 555", 30));



            lBoxAlojamientos.Items.Clear();
            foreach(Propiedad p in alojamientos)
            {
                lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FCargaAlojamientos fModificarAlojamiento = new FCargaAlojamientos();
            int itemSeleccionado = lBoxAlojamientos.SelectedIndex;

            //fModificarAlojamiento.tbDireccion.Text = "hola";

            fModificarAlojamiento.tbDireccion.Text = ((Propiedad)alojamientos[itemSeleccionado]).Direccion;
            fModificarAlojamiento.tbNroPropiedad.Text = ((Propiedad)alojamientos[itemSeleccionado]).Numero.ToString();

            int numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);

            if (fModificarAlojamiento.ShowDialog() == DialogResult.OK)
            {
                string direccion = fModificarAlojamiento.tbDireccion.Text;
                numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);

                ((Propiedad)alojamientos[itemSeleccionado]).Direccion = direccion;
                ((Propiedad)alojamientos[itemSeleccionado]).Numero = numeroPropiedad;

                //alojamientos.Add(new Propiedad(direccion, numeroPropiedad));
                lBoxAlojamientos.Items.Clear();
                foreach (Propiedad p in alojamientos)
                {
                    lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero);
                }

            }

            //string direccion = vCargaAlojamiento.tbDireccion.Text;
            //int numeroPropiedad = Convert.ToInt32(vCargaAlojamiento.tbNroPropiedad.Text);



        }
    }
}

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
using System.Drawing.Drawing2D;

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
        string miarchivo = Application.StartupPath + ("\\reservas.txt");
        FileStream miStream;
        string foto1;

        private void Form1_Load(object sender, EventArgs e)
        {     // Bordes Ventana
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Ajusta el radio según tu preferencia

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);

            // Posicion Inicial
            // Cambiar la posición de la ventana a las coordenadas (x, y)
            // Obtener el tamaño de la pantalla
            Screen screen = Screen.FromControl(this);
            int x = (screen.WorkingArea.Width - this.Width) / 2;
            int y = (screen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(x, y);

            // Boton Redondeado

            Button button = new Button();
            button.Width = 100;
            button.Height = 40;
            button.Text = "Botón redondeado";

            int radio = 10; // Ajusta el radio según tu preferencia

            GraphicsPath path1 = new GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);

            Region region = new Region(path1);
            button.Region = region;

            this.Controls.Add(button);

            // ----------------------------------------------------    
            //VENTANA INICIAL
            //FPrecioBase vPrecioBase = new FPrecioBase();
            //if (vPrecioBase.ShowDialog() == DialogResult.OK)
            //{
            //    precioBase = Convert.ToDouble(vPrecioBase.tbPrecioBase.Text);
            //    //miSistema = new Sistema(precioBase);
            //    MessageBox.Show($"Precio base: {precioBase} ingresado correctamente");
            //}
            //else
            //{
            //    MessageBox.Show("Cancelado por usuario");
            //}
            //miSistema.AgregarPropiedades(new Propiedad("Colon 236", 20, "Casa Por Dia"));
            //miSistema.AgregarPropiedades(new Propiedad("San Juan 555", 30, "Casa Por Dia"));

            //miSistema.AgregarCliente("Diego Perez", 22654987, "Callao 50");
            //miSistema.AgregarCliente("Jose Comez", 29854987, "Calle D 25");

            //  alojamientos.Add(new Propiedad("San Juan 555", 30));

            //  Deserializar();
            // 1. Crear Stream
            miStream = new FileStream(miarchivo, FileMode.Open, FileAccess.Read, FileShare.None);

            // 2.- Crear Formateador
            BinaryFormatter formateador = new BinaryFormatter();

            // 3.- Serialiar
            miSistema = (Sistema)formateador.Deserialize(miStream);
            //laAgenda = (agenda)serUnser.Deserialize(archivo);

            // 4.- Cerrar Stream
            miStream.Close();

            CargarDatos();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {     // Proceso De Serializar

            // 1. Crear Stream
             miStream = new FileStream(miarchivo, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

            // 2.- Crear Formateador
            BinaryFormatter formateador = new BinaryFormatter();

            // 3.- Serialiar
            formateador.Serialize(miStream, miSistema);

            // 4.- Cerrar Stream
            miStream.Close();
        }


        private void CargarDatos() 
        {
            lBoxAlojamientos.Items.Clear();
            lbClientes.Items.Clear();
            dataGridView1.Rows.Clear();
            //lbReservas.Items.Clear();
;            foreach (Propiedad p in miSistema.ListarPropiedades())
            {
                lBoxAlojamientos.Items.Add(p.Direccion + " " + p.Numero + " " + p.TipoPropiedad);
            }

            foreach(Cliente c in miSistema.ListarClientes())
            {
                lbClientes.Items.Add($"{c.Nombre} - {c.Direccion}");
            }

            int cantreservas = 1;
            foreach (Reserva r in miSistema.ListarReservas())
            {
               // lbReservas.Items.Add(cantreservas.ToString("00") + " " + r.NuevoCliente.Nombre + " " + r.Alojamiento.Direccion + " - Reservado: " + r.FechaCheckin.ToString("dd-MM-yyyy"));
                //lbReservas.Items.Add(r.FechaCheckin.ToString("dddd", new CultureInfo("es-ES")));

                // DataGrid
                int filaIndex = dataGridView1.Rows.Add(); // Agregar una nueva fila
                DataGridViewRow fila = dataGridView1.Rows[filaIndex]; // Obtener la fila

                // Asignar los valores de las celdas
                fila.Cells["Nro"].Value = cantreservas.ToString("00");

                fila.Cells["Nombre"].Value = r.NuevoCliente.Nombre;
                fila.Cells["Dni"].Value = r.NuevoCliente.Dni;

                //fila.Cells["Alojamiento"].Value = r.Alojamiento.Direccion;
                fila.Cells["Alojamiento"].Value = r.Alojamiento.TipoPropiedad;

                fila.Cells["Dias"].Value = r.CantidadDeDias;

                //fila.Cells["Precio"].Value = r.PrecioFinal.ToString("00,000");
                fila.Cells["Precio"].Value = r.PrecioFinal;

                fila.Cells["checkin"].Value = r.FechaCheckin.ToString("d");
                fila.Cells["checkout"].Value = r.FechaCheckOut.ToString("d");


                cantreservas++;
            }        
        }

        private void btnAltaAlojamiento_Click(object sender, EventArgs e)
        {
            FCargaAlojamientos vCargaAlojamiento = new FCargaAlojamientos();
           



            try
                {
                if (vCargaAlojamiento.ShowDialog() == DialogResult.OK)
                {
                    string direccion = vCargaAlojamiento.tbDireccion.Text;
                    int numeroPropiedad = Convert.ToInt32(vCargaAlojamiento.tbNroPropiedad.Text);
                    string tipoAlojamiento = vCargaAlojamiento.cbTipoAlojamiento.Text;

                    miSistema.AgregarPropiedades(new Propiedad(direccion, numeroPropiedad, tipoAlojamiento));
                    CargarDatos();
                    vCargaAlojamiento.Dispose();
                }           
            }
                catch (FormatException) 
                {
                    MessageBox.Show("Debe ingresar un numero");
                }
               
                //   alojamientos.Add();
                       
        }

        private void Deserializar()
        {
            
        }

        private void Serializar()
        {
            // Proceso Serializar

            // 1. Crear Stream
            FileStream miStream = new FileStream("C:/Users/alexx/Documents/alojamientos.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            // 2.- Crear Formateador
            BinaryFormatter formateador = new BinaryFormatter();

            // 3.- Serialiar
            formateador.Serialize(miStream, miSistema);
            
            // 4.- Cerrar Stream
            miStream.Close();
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
                // Configura la imagen para el primer PictureBox
                //fModificarAlojamiento.pictureBox1.Image = Image.FromFile("C:/Users/Alexx/Pictures/casas/casa2.jpg");
                //fModificarAlojamiento.pictureBox2.Image = Image.FromFile("C:/Users/Alexx/Pictures/casas/casa2.jpg");
                //fModificarAlojamiento.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\casa2.jpg");

                fModificarAlojamiento.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/alojamientos\casa2.jpg");
                fModificarAlojamiento.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"/alojamientos\casa1.jpg");

                //string path = @"\myvideo.wmv";

                //path = Application.StartupPath + path;



                //pictureBox1.Image = Image.FromFile("imagen1.jpg");

                if (fModificarAlojamiento.ShowDialog() == DialogResult.OK)
                {
                    string direccion = fModificarAlojamiento.tbDireccion.Text;
                    numeroPropiedad = Convert.ToInt32(fModificarAlojamiento.tbNroPropiedad.Text);

                    //  ((Propiedad)alojamientos[itemSeleccionado]).Direccion = direccion;
                    // ((Propiedad)alojamientos[itemSeleccionado]).Numero = numeroPropiedad;

                    miSistema.ModificarPropiedad(itemSeleccionado, direccion, numeroPropiedad);
                    //alojamientos.Add(new Propiedad(direccion, numeroPropiedad));

                    // Ruta de la imagen que deseas cargar
                    string rutaDeLaImagen = Application.StartupPath + "\\casa1.jpg";
                    try
                    {
                        // Cargar la imagen desde la ruta de archivo
                        Image imagen = Image.FromFile(rutaDeLaImagen);

                        // Asignar la imagen al PictureBox
                        fModificarAlojamiento.pictureBox1.Image = imagen;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    CargarDatos();
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
           
            foreach(Propiedad p in miSistema.ListarPropiedades())
            {
                vReservas.cbAlojamientos.Items.Add(p.Direccion);
            }
            foreach(Cliente c in miSistema.ListarClientes())
            {
                vReservas.cbListaClientes.Items.Add(c.Nombre);
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

                int indiceclienteSeleccionado = vReservas.cbListaClientes.SelectedIndex;
                Cliente clienteSeleccionado = miSistema.BuscarCliente(indiceclienteSeleccionado);
                MessageBox.Show($"Fecha de inicio: {fechaInicio}\nFecha de fin: {fechaFin}\n Total Dias: { diasDiferencia}\n Lugar: {alojamientoSeleccionado.Direccion}");

                miSistema.AgregarReserva(fechaInicio, fechaFin, diasDiferencia, alojamientoSeleccionado, clienteSeleccionado);

                CargarDatos();


                //int cantreservas = 1;
                //lbReservas.Items.Clear();
                //foreach(Reserva r in miSistema.ListarReservas())
                //{                
                //    lbReservas.Items.Add(cantreservas.ToString("00") + " " + r.NuevoCliente.Nombre +  " " + r.Alojamiento.Direccion +  " - Reservado: " +  r.FechaCheckin.ToString("dd-MM-yyyy"));
                //    //lbReservas.Items.Add(r.FechaCheckin.ToString("dddd", new CultureInfo("es-ES")));
                //    cantreservas++;
                //}           
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
                CargarDatos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un item de la lista");
            }
            
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            fRegistrarCliente vRegistrarCliente = new fRegistrarCliente();
            if ( vRegistrarCliente.ShowDialog() == DialogResult.OK)
            {
                miSistema.AgregarCliente(vRegistrarCliente.tbNombreCliente.Text, 
                    Convert.ToInt32(vRegistrarCliente.tbDniCliente.Text), vRegistrarCliente.tbDireccionCliente.Text);
                MessageBox.Show($"Cliente {vRegistrarCliente.tbNombreCliente.Text}\n Registrado exitosamente !!");
            }
            vRegistrarCliente.Dispose();

            CargarDatos();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

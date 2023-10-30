using System;
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
    public partial class FCargaAlojamientos : Form
    {
        public FCargaAlojamientos()
        {
            InitializeComponent();

        }

        // Falta pasar los datos a la ventanna de carga de Alojamientos y mandar las fotos al constructor
        private List<string> fotos = new List<string>();
        public List<string> Fotos { get { return fotos; } }
        string fotoSeleccionada;

        private string CargarFoto()
        {
            string foto;
            OpenFileDialog opfd = new OpenFileDialog();
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                foto = opfd.FileName;
                // Cargar la imagen desde la ruta de archivo
                // Image imagen1 = Image.FromFile(foto1);
                // pictureBox1.Image = imagen1;
                
            }
           
            return opfd.FileName;
            opfd.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fotoSeleccionada = CargarFoto();
            Image imagen1 = Image.FromFile(fotoSeleccionada);
            pictureBox1.Image = imagen1;
            fotos.Add(fotoSeleccionada);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fotoSeleccionada = CargarFoto();
            Image imagen2 = Image.FromFile(fotoSeleccionada);
            pictureBox2.Image = imagen2;
            fotos.Add(CargarFoto());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fotoSeleccionada = CargarFoto();
            Image imagen3 = Image.FromFile(fotoSeleccionada);
            pictureBox3.Image = imagen3;
            fotos.Add(fotoSeleccionada);
        }




        private void btnFoto1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                string foto1 = opfd.FileName;
                // Cargar la imagen desde la ruta de archivo
                Image imagen1 = Image.FromFile(foto1);
                pictureBox1.Image = imagen1;
            }
        }

        
    }

}

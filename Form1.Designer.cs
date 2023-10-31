
namespace TP_2_LAB___2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAltaAlojamiento = new System.Windows.Forms.Button();
            this.lBoxAlojamientos = new System.Windows.Forms.ListBox();
            this.labAlojamiento = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarReservas = new System.Windows.Forms.Button();
            this.btnModificarReservas = new System.Windows.Forms.Button();
            this.btnAltaReservas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAltaAlojamiento);
            this.panel1.Controls.Add(this.lBoxAlojamientos);
            this.panel1.Controls.Add(this.labAlojamiento);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 294);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(222, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BorrarAlojamiento_click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(119, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 39);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAltaAlojamiento
            // 
            this.btnAltaAlojamiento.Location = new System.Drawing.Point(10, 219);
            this.btnAltaAlojamiento.Name = "btnAltaAlojamiento";
            this.btnAltaAlojamiento.Size = new System.Drawing.Size(88, 39);
            this.btnAltaAlojamiento.TabIndex = 2;
            this.btnAltaAlojamiento.Text = "Alta";
            this.btnAltaAlojamiento.UseVisualStyleBackColor = true;
            this.btnAltaAlojamiento.Click += new System.EventHandler(this.btnAltaAlojamiento_Click);
            // 
            // lBoxAlojamientos
            // 
            this.lBoxAlojamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxAlojamientos.FormattingEnabled = true;
            this.lBoxAlojamientos.ItemHeight = 20;
            this.lBoxAlojamientos.Location = new System.Drawing.Point(3, 42);
            this.lBoxAlojamientos.Name = "lBoxAlojamientos";
            this.lBoxAlojamientos.Size = new System.Drawing.Size(300, 164);
            this.lBoxAlojamientos.TabIndex = 1;
            // 
            // labAlojamiento
            // 
            this.labAlojamiento.AutoSize = true;
            this.labAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlojamiento.Location = new System.Drawing.Point(58, 7);
            this.labAlojamiento.Name = "labAlojamiento";
            this.labAlojamiento.Size = new System.Drawing.Size(177, 32);
            this.labAlojamiento.TabIndex = 0;
            this.labAlojamiento.Text = "Alojamiento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnBorrarCliente);
            this.panel2.Controls.Add(this.btnModificarCliente);
            this.panel2.Controls.Add(this.btnRegistrarCliente);
            this.panel2.Controls.Add(this.lbClientes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 366);
            this.panel2.TabIndex = 1;
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrarCliente.Location = new System.Drawing.Point(222, 296);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(88, 39);
            this.btnBorrarCliente.TabIndex = 4;
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.UseVisualStyleBackColor = false;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(119, 297);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(88, 39);
            this.btnModificarCliente.TabIndex = 3;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(10, 297);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(88, 39);
            this.btnRegistrarCliente.TabIndex = 2;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 20;
            this.lbClientes.Location = new System.Drawing.Point(3, 53);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(300, 164);
            this.lbClientes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // btnBorrarReservas
            // 
            this.btnBorrarReservas.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarReservas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrarReservas.Location = new System.Drawing.Point(699, 528);
            this.btnBorrarReservas.Name = "btnBorrarReservas";
            this.btnBorrarReservas.Size = new System.Drawing.Size(101, 39);
            this.btnBorrarReservas.TabIndex = 4;
            this.btnBorrarReservas.Text = "Borrar";
            this.btnBorrarReservas.UseVisualStyleBackColor = false;
            // 
            // btnModificarReservas
            // 
            this.btnModificarReservas.Location = new System.Drawing.Point(531, 529);
            this.btnModificarReservas.Name = "btnModificarReservas";
            this.btnModificarReservas.Size = new System.Drawing.Size(101, 39);
            this.btnModificarReservas.TabIndex = 3;
            this.btnModificarReservas.Text = "Modificar";
            this.btnModificarReservas.UseVisualStyleBackColor = true;
            // 
            // btnAltaReservas
            // 
            this.btnAltaReservas.Location = new System.Drawing.Point(884, 529);
            this.btnAltaReservas.Name = "btnAltaReservas";
            this.btnAltaReservas.Size = new System.Drawing.Size(101, 39);
            this.btnAltaReservas.TabIndex = 2;
            this.btnAltaReservas.Text = "Dar de Alta";
            this.btnAltaReservas.UseVisualStyleBackColor = true;
            this.btnAltaReservas.Click += new System.EventHandler(this.btnAltaReservas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1044, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(350, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1088, 482);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reservas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.nombre,
            this.dni,
            this.alojamiento,
            this.dias,
            this.checkin,
            this.checkout,
            this.precio});
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // nro
            // 
            this.nro.HeaderText = "Nro";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.Width = 30;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 150F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.Width = 80;
            // 
            // alojamiento
            // 
            this.alojamiento.HeaderText = "Alojamiento";
            this.alojamiento.MinimumWidth = 6;
            this.alojamiento.Name = "alojamiento";
            this.alojamiento.Width = 140;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias";
            this.dias.MinimumWidth = 6;
            this.dias.Name = "dias";
            this.dias.Width = 40;
            // 
            // checkin
            // 
            this.checkin.FillWeight = 125F;
            this.checkin.HeaderText = "Check In";
            this.checkin.MinimumWidth = 6;
            this.checkin.Name = "checkin";
            this.checkin.Width = 110;
            // 
            // checkout
            // 
            this.checkout.HeaderText = "Check Out";
            this.checkout.MinimumWidth = 6;
            this.checkout.Name = "checkout";
            this.checkout.Width = 110;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 95;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PepperHot;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(879, 621);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(105, 49);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 702);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1423, 713);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnAltaReservas);
            this.Controls.Add(this.btnBorrarReservas);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnModificarReservas);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Inmobiliaria Tu Casa v 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labAlojamiento;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAltaAlojamiento;
        private System.Windows.Forms.ListBox lBoxAlojamientos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarReservas;
        private System.Windows.Forms.Button btnModificarReservas;
        private System.Windows.Forms.Button btnAltaReservas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn alojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}


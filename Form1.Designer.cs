
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBorrarReservas = new System.Windows.Forms.Button();
            this.btnModificarReservas = new System.Windows.Forms.Button();
            this.btnAltaReservas = new System.Windows.Forms.Button();
            this.lbReservas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 323);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(20, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BorrarAlojamiento_click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(20, 171);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 39);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAltaAlojamiento
            // 
            this.btnAltaAlojamiento.Location = new System.Drawing.Point(20, 95);
            this.btnAltaAlojamiento.Name = "btnAltaAlojamiento";
            this.btnAltaAlojamiento.Size = new System.Drawing.Size(101, 39);
            this.btnAltaAlojamiento.TabIndex = 2;
            this.btnAltaAlojamiento.Text = "Dar de Alta";
            this.btnAltaAlojamiento.UseVisualStyleBackColor = true;
            this.btnAltaAlojamiento.Click += new System.EventHandler(this.btnAltaAlojamiento_Click);
            // 
            // lBoxAlojamientos
            // 
            this.lBoxAlojamientos.FormattingEnabled = true;
            this.lBoxAlojamientos.ItemHeight = 16;
            this.lBoxAlojamientos.Location = new System.Drawing.Point(139, 53);
            this.lBoxAlojamientos.Name = "lBoxAlojamientos";
            this.lBoxAlojamientos.Size = new System.Drawing.Size(296, 228);
            this.lBoxAlojamientos.TabIndex = 1;
            // 
            // labAlojamiento
            // 
            this.labAlojamiento.AutoSize = true;
            this.labAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlojamiento.Location = new System.Drawing.Point(133, 7);
            this.labAlojamiento.Name = "labAlojamiento";
            this.labAlojamiento.Size = new System.Drawing.Size(177, 32);
            this.labAlojamiento.TabIndex = 0;
            this.labAlojamiento.Text = "Alojamiento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(463, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 323);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(20, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "Registrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(139, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 228);
            this.listBox1.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BurlyWood;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnBorrarReservas);
            this.panel3.Controls.Add(this.btnModificarReservas);
            this.panel3.Controls.Add(this.btnAltaReservas);
            this.panel3.Controls.Add(this.lbReservas);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(859, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 323);
            this.panel3.TabIndex = 2;
            // 
            // btnBorrarReservas
            // 
            this.btnBorrarReservas.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarReservas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrarReservas.Location = new System.Drawing.Point(20, 237);
            this.btnBorrarReservas.Name = "btnBorrarReservas";
            this.btnBorrarReservas.Size = new System.Drawing.Size(101, 39);
            this.btnBorrarReservas.TabIndex = 4;
            this.btnBorrarReservas.Text = "Borrar";
            this.btnBorrarReservas.UseVisualStyleBackColor = false;
            // 
            // btnModificarReservas
            // 
            this.btnModificarReservas.Location = new System.Drawing.Point(20, 171);
            this.btnModificarReservas.Name = "btnModificarReservas";
            this.btnModificarReservas.Size = new System.Drawing.Size(101, 39);
            this.btnModificarReservas.TabIndex = 3;
            this.btnModificarReservas.Text = "Modificar";
            this.btnModificarReservas.UseVisualStyleBackColor = true;
            // 
            // btnAltaReservas
            // 
            this.btnAltaReservas.Location = new System.Drawing.Point(20, 95);
            this.btnAltaReservas.Name = "btnAltaReservas";
            this.btnAltaReservas.Size = new System.Drawing.Size(101, 39);
            this.btnAltaReservas.TabIndex = 2;
            this.btnAltaReservas.Text = "Dar de Alta";
            this.btnAltaReservas.UseVisualStyleBackColor = true;
            this.btnAltaReservas.Click += new System.EventHandler(this.btnAltaReservas_Click);
            // 
            // lbReservas
            // 
            this.lbReservas.FormattingEnabled = true;
            this.lbReservas.ItemHeight = 16;
            this.lbReservas.Location = new System.Drawing.Point(139, 53);
            this.lbReservas.Name = "lbReservas";
            this.lbReservas.Size = new System.Drawing.Size(381, 228);
            this.lbReservas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reservas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1604, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBorrarReservas;
        private System.Windows.Forms.Button btnModificarReservas;
        private System.Windows.Forms.Button btnAltaReservas;
        private System.Windows.Forms.ListBox lbReservas;
        private System.Windows.Forms.Label label2;
    }
}


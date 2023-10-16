
namespace TP_2_LAB___2
{
    partial class FCargaAlojamientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNroPropiedad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(45, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(273, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNroPropiedad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbDireccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 198);
            this.panel1.TabIndex = 4;
            // 
            // tbNroPropiedad
            // 
            this.tbNroPropiedad.Location = new System.Drawing.Point(159, 70);
            this.tbNroPropiedad.Name = "tbNroPropiedad";
            this.tbNroPropiedad.Size = new System.Drawing.Size(100, 22);
            this.tbNroPropiedad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro Propiedad";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(159, 21);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 22);
            this.tbDireccion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Direccion";
            // 
            // FCargaAlojamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FCargaAlojamientos";
            this.Text = "FCargaAlojamientos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbNroPropiedad;
        public System.Windows.Forms.TextBox tbDireccion;
    }
}
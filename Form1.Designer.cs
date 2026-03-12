namespace Simulacro_Examen_Parcial
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAlumnos = new System.Windows.Forms.TabPage();
            this.tabPageTaller = new System.Windows.Forms.TabPage();
            this.tabPageInscripciones = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlumnos);
            this.tabControl1.Controls.Add(this.tabPageTaller);
            this.tabControl1.Controls.Add(this.tabPageInscripciones);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAlumnos
            // 
            this.tabPageAlumnos.Controls.Add(this.labelDireccion);
            this.tabPageAlumnos.Controls.Add(this.labelNombre);
            this.tabPageAlumnos.Controls.Add(this.labelDpi);
            this.tabPageAlumnos.Controls.Add(this.textBox3);
            this.tabPageAlumnos.Controls.Add(this.textBox2);
            this.tabPageAlumnos.Controls.Add(this.textBox1);
            this.tabPageAlumnos.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlumnos.Name = "tabPageAlumnos";
            this.tabPageAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlumnos.Size = new System.Drawing.Size(776, 406);
            this.tabPageAlumnos.TabIndex = 0;
            this.tabPageAlumnos.Text = "Alumnos";
            this.tabPageAlumnos.UseVisualStyleBackColor = true;
            // 
            // tabPageTaller
            // 
            this.tabPageTaller.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaller.Name = "tabPageTaller";
            this.tabPageTaller.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaller.Size = new System.Drawing.Size(776, 406);
            this.tabPageTaller.TabIndex = 1;
            this.tabPageTaller.Text = "Taller";
            this.tabPageTaller.UseVisualStyleBackColor = true;
            // 
            // tabPageInscripciones
            // 
            this.tabPageInscripciones.Location = new System.Drawing.Point(4, 25);
            this.tabPageInscripciones.Name = "tabPageInscripciones";
            this.tabPageInscripciones.Size = new System.Drawing.Size(776, 406);
            this.tabPageInscripciones.TabIndex = 2;
            this.tabPageInscripciones.Text = "Inscripciones";
            this.tabPageInscripciones.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 22);
            this.textBox3.TabIndex = 2;
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Location = new System.Drawing.Point(195, 86);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(29, 16);
            this.labelDpi.TabIndex = 3;
            this.labelDpi.Text = "DPI";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(182, 180);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(182, 273);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(64, 16);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Direccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlumnos.ResumeLayout(false);
            this.tabPageAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlumnos;
        private System.Windows.Forms.TabPage tabPageTaller;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPageInscripciones;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDpi;
    }
}


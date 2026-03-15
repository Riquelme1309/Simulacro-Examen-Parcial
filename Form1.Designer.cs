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
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDpi = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxCodigoTaller = new System.Windows.Forms.TextBox();
            this.textBoxNombreTaller = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.labelCodigoTaller = new System.Windows.Forms.Label();
            this.labelNombreTaller = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTaller = new System.Windows.Forms.Label();
            this.tabPageReporte = new System.Windows.Forms.TabPage();
            this.buttonInscrito = new System.Windows.Forms.Button();
            this.buttonGuardarTaller = new System.Windows.Forms.Button();
            this.buttonGuardarAlumnos = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.comboBoxTaller = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAlumnos.SuspendLayout();
            this.tabPageTaller.SuspendLayout();
            this.tabPageInscripciones.SuspendLayout();
            this.tabPageReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAlumnos);
            this.tabControl1.Controls.Add(this.tabPageTaller);
            this.tabControl1.Controls.Add(this.tabPageInscripciones);
            this.tabControl1.Controls.Add(this.tabPageReporte);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAlumnos
            // 
            this.tabPageAlumnos.Controls.Add(this.buttonGuardarAlumnos);
            this.tabPageAlumnos.Controls.Add(this.labelDireccion);
            this.tabPageAlumnos.Controls.Add(this.labelNombre);
            this.tabPageAlumnos.Controls.Add(this.labelDpi);
            this.tabPageAlumnos.Controls.Add(this.textBoxDireccion);
            this.tabPageAlumnos.Controls.Add(this.textBoxNombre);
            this.tabPageAlumnos.Controls.Add(this.textBoxDpi);
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
            this.tabPageTaller.Controls.Add(this.buttonGuardarTaller);
            this.tabPageTaller.Controls.Add(this.labelCosto);
            this.tabPageTaller.Controls.Add(this.labelNombreTaller);
            this.tabPageTaller.Controls.Add(this.labelCodigoTaller);
            this.tabPageTaller.Controls.Add(this.textBoxCosto);
            this.tabPageTaller.Controls.Add(this.textBoxNombreTaller);
            this.tabPageTaller.Controls.Add(this.textBoxCodigoTaller);
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
            this.tabPageInscripciones.Controls.Add(this.comboBoxTaller);
            this.tabPageInscripciones.Controls.Add(this.comboBoxAlumno);
            this.tabPageInscripciones.Controls.Add(this.buttonInscrito);
            this.tabPageInscripciones.Controls.Add(this.labelTaller);
            this.tabPageInscripciones.Controls.Add(this.label1);
            this.tabPageInscripciones.Location = new System.Drawing.Point(4, 25);
            this.tabPageInscripciones.Name = "tabPageInscripciones";
            this.tabPageInscripciones.Size = new System.Drawing.Size(776, 406);
            this.tabPageInscripciones.TabIndex = 2;
            this.tabPageInscripciones.Text = "Inscripciones";
            this.tabPageInscripciones.UseVisualStyleBackColor = true;
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(273, 80);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(263, 22);
            this.textBoxDpi.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(273, 177);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(263, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(273, 267);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(263, 22);
            this.textBoxDireccion.TabIndex = 2;
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
            // textBoxCodigoTaller
            // 
            this.textBoxCodigoTaller.Location = new System.Drawing.Point(268, 81);
            this.textBoxCodigoTaller.Name = "textBoxCodigoTaller";
            this.textBoxCodigoTaller.Size = new System.Drawing.Size(213, 22);
            this.textBoxCodigoTaller.TabIndex = 0;
            // 
            // textBoxNombreTaller
            // 
            this.textBoxNombreTaller.Location = new System.Drawing.Point(268, 188);
            this.textBoxNombreTaller.Name = "textBoxNombreTaller";
            this.textBoxNombreTaller.Size = new System.Drawing.Size(213, 22);
            this.textBoxNombreTaller.TabIndex = 1;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(268, 309);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(213, 22);
            this.textBoxCosto.TabIndex = 2;
            // 
            // labelCodigoTaller
            // 
            this.labelCodigoTaller.AutoSize = true;
            this.labelCodigoTaller.Location = new System.Drawing.Point(130, 82);
            this.labelCodigoTaller.Name = "labelCodigoTaller";
            this.labelCodigoTaller.Size = new System.Drawing.Size(105, 16);
            this.labelCodigoTaller.TabIndex = 3;
            this.labelCodigoTaller.Text = "Codigo del taller";
            // 
            // labelNombreTaller
            // 
            this.labelNombreTaller.AutoSize = true;
            this.labelNombreTaller.Location = new System.Drawing.Point(125, 191);
            this.labelNombreTaller.Name = "labelNombreTaller";
            this.labelNombreTaller.Size = new System.Drawing.Size(110, 16);
            this.labelNombreTaller.TabIndex = 4;
            this.labelNombreTaller.Text = "Nombre del taller";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(153, 315);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(42, 16);
            this.labelCosto.TabIndex = 5;
            this.labelCosto.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alumno";
            // 
            // labelTaller
            // 
            this.labelTaller.AutoSize = true;
            this.labelTaller.Location = new System.Drawing.Point(92, 193);
            this.labelTaller.Name = "labelTaller";
            this.labelTaller.Size = new System.Drawing.Size(42, 16);
            this.labelTaller.TabIndex = 4;
            this.labelTaller.Text = "Taller";
            // 
            // tabPageReporte
            // 
            this.tabPageReporte.Controls.Add(this.buttonTotal);
            this.tabPageReporte.Controls.Add(this.buttonOrdenar);
            this.tabPageReporte.Controls.Add(this.buttonReporte);
            this.tabPageReporte.Controls.Add(this.dataGridView1);
            this.tabPageReporte.Location = new System.Drawing.Point(4, 25);
            this.tabPageReporte.Name = "tabPageReporte";
            this.tabPageReporte.Size = new System.Drawing.Size(776, 406);
            this.tabPageReporte.TabIndex = 3;
            this.tabPageReporte.Text = "Reporte";
            this.tabPageReporte.UseVisualStyleBackColor = true;
            // 
            // buttonInscrito
            // 
            this.buttonInscrito.Location = new System.Drawing.Point(314, 268);
            this.buttonInscrito.Name = "buttonInscrito";
            this.buttonInscrito.Size = new System.Drawing.Size(114, 57);
            this.buttonInscrito.TabIndex = 6;
            this.buttonInscrito.Text = "Inscribir";
            this.buttonInscrito.UseVisualStyleBackColor = true;
            this.buttonInscrito.Click += new System.EventHandler(this.buttonGuardarInscripciones_Click);
            // 
            // buttonGuardarTaller
            // 
            this.buttonGuardarTaller.Location = new System.Drawing.Point(581, 167);
            this.buttonGuardarTaller.Name = "buttonGuardarTaller";
            this.buttonGuardarTaller.Size = new System.Drawing.Size(125, 65);
            this.buttonGuardarTaller.TabIndex = 6;
            this.buttonGuardarTaller.Text = "Guardar";
            this.buttonGuardarTaller.UseVisualStyleBackColor = true;
            this.buttonGuardarTaller.Click += new System.EventHandler(this.buttonGuardarTaller_Click);
            // 
            // buttonGuardarAlumnos
            // 
            this.buttonGuardarAlumnos.Location = new System.Drawing.Point(608, 155);
            this.buttonGuardarAlumnos.Name = "buttonGuardarAlumnos";
            this.buttonGuardarAlumnos.Size = new System.Drawing.Size(115, 67);
            this.buttonGuardarAlumnos.TabIndex = 6;
            this.buttonGuardarAlumnos.Text = "Guardar";
            this.buttonGuardarAlumnos.UseVisualStyleBackColor = true;
            this.buttonGuardarAlumnos.Click += new System.EventHandler(this.buttonGuardarAlumnos_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(91, 349);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(157, 38);
            this.buttonReporte.TabIndex = 1;
            this.buttonReporte.Text = "Gerar Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(239, 69);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(275, 24);
            this.comboBoxAlumno.TabIndex = 7;
            // 
            // comboBoxTaller
            // 
            this.comboBoxTaller.FormattingEnabled = true;
            this.comboBoxTaller.Location = new System.Drawing.Point(239, 185);
            this.comboBoxTaller.Name = "comboBoxTaller";
            this.comboBoxTaller.Size = new System.Drawing.Size(275, 24);
            this.comboBoxTaller.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(294, 349);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(191, 38);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(549, 354);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(171, 29);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAlumnos.ResumeLayout(false);
            this.tabPageAlumnos.PerformLayout();
            this.tabPageTaller.ResumeLayout(false);
            this.tabPageTaller.PerformLayout();
            this.tabPageInscripciones.ResumeLayout(false);
            this.tabPageInscripciones.PerformLayout();
            this.tabPageReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAlumnos;
        private System.Windows.Forms.TabPage tabPageTaller;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.TabPage tabPageInscripciones;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.Label labelCodigoTaller;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.TextBox textBoxNombreTaller;
        private System.Windows.Forms.TextBox textBoxCodigoTaller;
        private System.Windows.Forms.Label labelNombreTaller;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelTaller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardarAlumnos;
        private System.Windows.Forms.Button buttonGuardarTaller;
        private System.Windows.Forms.Button buttonInscrito;
        private System.Windows.Forms.TabPage tabPageReporte;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.ComboBox comboBoxTaller;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Button buttonOrdenar;
    }
}


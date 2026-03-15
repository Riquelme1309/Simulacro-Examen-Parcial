using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacro_Examen_Parcial
{
    public partial class Form1 : Form
    {
        List<Alumnos> alumnos = new List<Alumnos>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripciones> inscripciones = new List<Inscripciones>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerAlumno()
        {
            string filename = @"Alumno.txt";
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Alumnos alumno = new Alumnos();
                alumno.Dpi = Convert.ToInt16 (reader.ReadLine());
                alumno.Nombre = reader.ReadLine();
                alumno.Direccion = reader.ReadLine();

                alumnos.Add(alumno);

            }
            reader.Close();
        }
        private void GuardarAlumnos()
        {
            Alumnos alumno = new Alumnos();
            alumno.Dpi = Convert.ToInt16(textBoxDpi.Text);
            alumno.Nombre = textBoxNombre.Text;
            alumno.Direccion = textBoxDireccion.Text;

            alumnos.Add(alumno);

            string filename = @"Alumno.txt";
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(alumno.Dpi);
            writer.WriteLine(alumno.Nombre);
            writer.WriteLine(alumno.Direccion);

            writer.Close();

            MessageBox.Show("Alumno guardado");
        }

        private void LeerTaller()
        {
            string filename = @"Taller.txt";
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Taller taller = new Taller();
                taller.Codigotaller = reader.ReadLine();
                taller.NombreTaller = reader.ReadLine();
                taller.Costo = Convert.ToDecimal(reader.ReadLine());

                talleres.Add(taller);
            }

            reader.Close();
        }

        private void GuardarTaller()
        {
            Taller taller = new Taller();
            taller.Codigotaller = textBoxCodigoTaller.Text;
            taller.NombreTaller = textBoxNombreTaller.Text;
            taller.Costo = Convert.ToDecimal(textBoxCosto.Text);

            talleres.Add(taller);

            string filename = @"Taller.txt";
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(taller.Codigotaller);
            writer.WriteLine(taller.NombreTaller);
            writer.WriteLine(taller.Costo);

            writer.Close();

            MessageBox.Show("Taller guardado");
        }
        private void GuardarInscripciones()
        {
            Alumnos alumno = (Alumnos)comboBoxAlumno.SelectedItem;
            Taller taller = (Taller)comboBoxTaller.SelectedItem;

            Inscripciones inscripcion = new Inscripciones();

            inscripcion.DpiEstudiante = alumno.Dpi;
            inscripcion.TallerCodigo = taller.Codigotaller;
            inscripcion.FechaInscripcion = DateTime.Now;

            inscripciones.Add(inscripcion);

            string filename = @"Inscripciones.txt";
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(inscripcion.DpiEstudiante);
            writer.WriteLine(inscripcion.TallerCodigo);
            writer.WriteLine(inscripcion.FechaInscripcion);

            writer.Close();

            MessageBox.Show("Inscripción guardada");
        }
        private void GenerarReporte()
        {
            reportes.Clear();

            foreach (Inscripciones ins in inscripciones)
            {
                Alumnos alumno = alumnos.Find(a => a.Dpi == ins.DpiEstudiante);
                Taller taller = talleres.Find(t => t.Codigotaller == ins.TallerCodigo);

                if (alumno != null && taller != null)
                {
                    Reporte reporte = new Reporte();
                    reporte.NombreEstudiante= alumno.Nombre;
                    reporte.Taller = taller.NombreTaller;

                    reportes.Add(reporte);
                }
            }
        }

        private void buttonGuardarAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.Dpi = Convert.ToInt16 (textBoxDpi.Text);
            alumno.Nombre = textBoxNombre.Text;
            alumno.Direccion = textBoxDireccion.Text;

            alumnos.Add(alumno);
            GuardarAlumnos();
        }

        private void buttonGuardarTaller_Click(object sender, EventArgs e)
        {
            Taller taller = new Taller();
            taller.Codigotaller = textBoxCodigoTaller.Text;
            taller.NombreTaller = textBoxNombreTaller.Text;
            taller.Costo = Convert.ToDecimal (textBoxCosto.Text);

            talleres.Add(taller);

            GuardarTaller();
        }

        private void buttonGuardarInscripciones_Click(object sender, EventArgs e)
        {
            Alumnos alumno = (Alumnos)comboBoxAlumno.SelectedItem;
            Taller taller = (Taller)comboBoxTaller.SelectedItem;

            Inscripciones inscripcion = new Inscripciones();

            inscripcion.DpiEstudiante = alumno.Dpi;
            inscripcion.TallerCodigo = taller.Codigotaller;
            inscripcion.FechaInscripcion = DateTime.Now;

            inscripciones.Add(inscripcion);

            MessageBox.Show("Inscripción guardada");

            GuardarInscripciones();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerAlumno();
            LeerTaller();

            comboBoxAlumno.DataSource = alumnos;
            comboBoxAlumno.DisplayMember = "Nombre";

            comboBoxTaller.DataSource = talleres;
            comboBoxTaller.DisplayMember = "NombreTaller";

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Estudiante";
            dataGridView1.Columns[1].Name = "Taller";
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            GenerarReporte();

            foreach (Reporte r in reportes)
            {
                dataGridView1.Rows.Add(r.NombreEstudiante + " - " + r.Taller);
            }
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total inscritos: " + inscripciones.Count);
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(r => r.Taller).ToList();

            dataGridView1.Rows.Clear();

            foreach (Reporte r in reportes)
            {
                dataGridView1.Rows.Add(r.NombreEstudiante, r.Taller);
            }
        }
    }
}

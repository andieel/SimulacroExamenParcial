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

namespace SimulacroExamenParcial
{
    public partial class Form1 : Form
    {
        List<Alumno> alumnos = new List<Alumno>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerAlumnos()
        {
            FileStream stream = new FileStream("Alumnos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alumno alumno = new Alumno();

                alumno.Dpi = reader.ReadLine();
                alumno.Nombre = reader.ReadLine();
                alumno.Direccion = reader.ReadLine();

                alumnos.Add(alumno);
            }

            reader.Close();
        }
        private void LeerTalleres()
        {
            FileStream stream = new FileStream("Talleres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Taller taller = new Taller();

                taller.CodigoDelTaller = reader.ReadLine();
                taller.NombreDelTaller = reader.ReadLine();
                taller.Costo = Convert.ToDecimal(reader.ReadLine());

                talleres.Add(taller);
            }

            reader.Close();
        }
        private void LeerInscripciones()
        {
            FileStream stream = new FileStream("Inscripciones.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Inscripcion inscripcion = new Inscripcion();

                inscripcion.DpiDelEstudiante = reader.ReadLine();
                inscripcion.CodigoDelTaller = reader.ReadLine();
                inscripcion.FechaDeInscripcion = Convert.ToDateTime(reader.ReadLine());

                inscripciones.Add(inscripcion);
            }

            reader.Close();
        }
        private void GuardarInscripcion()
        {
            FileStream stream = new FileStream("Inscripciones.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var ins in inscripciones)
            {
                writer.WriteLine(ins.DpiDelEstudiante);
                writer.WriteLine(ins.CodigoDelTaller);
                writer.WriteLine(ins.FechaDeInscripcion);
            }

            writer.Close();
        }
        private void MostrarReporte()
        {
            var lista = new List<object>();

            foreach (var ins in inscripciones)
            {
                Alumno alumno = alumnos.Find(a => a.Dpi == ins.DpiDelEstudiante);
                Taller taller = talleres.Find(t => t.CodigoDelTaller == ins.CodigoDelTaller);

                lista.Add(new
                {
                    Alumno = alumno.Nombre,
                    Taller = taller.NombreDelTaller,
                    Fecha = ins.FechaDeInscripcion
                });
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LeerAlumnos();
            LeerTalleres();
            LeerInscripciones();

            comboBoxAlumno.DataSource = alumnos;
            comboBoxAlumno.DisplayMember = "Nombre";

            comboBoxTaller.DataSource = talleres;
            comboBoxTaller.DisplayMember = "NombreDeltaller";
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            
            Alumno alumno = (Alumno)comboBoxAlumno.SelectedItem;
            Taller taller = (Taller)comboBoxTaller.SelectedItem;

            Inscripcion inscripcion = new Inscripcion();

            inscripcion.DpiDelEstudiante = alumno.Dpi;
            inscripcion.CodigoDelTaller = taller.CodigoDelTaller;
            inscripcion.FechaDeInscripcion = DateTime.Now;

            inscripciones.Add(inscripcion);

            GuardarInscripcion();
        }
    }
    }
    


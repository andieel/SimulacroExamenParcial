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
        // Listas para almacenar los datos leídos de los archivos
        List<Alumno> alumnos = new List<Alumno>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para leer los alumnos desde el archivo de texto
        private void LeerAlumnos()
        {
            FileStream stream = new FileStream("Alumnos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            // Se leen los datos mientras no se llegue al final del archivo
            while (reader.Peek() > -1)
            {
                Alumno alumno = new Alumno();

                alumno.Dpi = reader.ReadLine();
                alumno.Nombre = reader.ReadLine();
                alumno.Direccion = reader.ReadLine();

                // Se agrega el alumno a la lista
                alumnos.Add(alumno);
            }

            reader.Close();
        }

        // Método para leer los talleres desde el archivo de texto
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

                // Se agrega el taller a la lista
                talleres.Add(taller);
            }

            reader.Close();
        }

        // Método para leer las inscripciones guardadas previamente
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

                // Se agrega la inscripción a la lista
                inscripciones.Add(inscripcion);
            }

            reader.Close();
        }

        // Método para guardar todas las inscripciones en el archivo
        private void GuardarInscripcion()
        {
            FileStream stream = new FileStream("Inscripciones.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            // Se recorren todas las inscripciones y se escriben en el archivo
            foreach (var ins in inscripciones)
            {
                writer.WriteLine(ins.DpiDelEstudiante);
                writer.WriteLine(ins.CodigoDelTaller);
                writer.WriteLine(ins.FechaDeInscripcion);
            }

            writer.Close();
        }

        // Método para mostrar el reporte en el DataGridView
        private void MostrarReporte()
        {
            var reporte = new List<object>();

            // Primero recorremos los talleres
            foreach (var tal in talleres)
            {
                // Luego buscamos las inscripciones que pertenecen a ese taller
                foreach (var ins in inscripciones)
                {
                    if (ins.CodigoDelTaller == tal.CodigoDelTaller)
                    {
                        string nombreAlumno = "";

                        // Buscar el nombre del alumno usando el DPI
                        foreach (var alu in alumnos)
                        {
                            if (alu.Dpi == ins.DpiDelEstudiante)
                            {
                                nombreAlumno = alu.Nombre;
                                break;
                            }
                        }

                        // Agregar la información al reporte
                        reporte.Add(new
                        {
                            Alumno = nombreAlumno,
                            Taller = tal.NombreDelTaller,
                            Fecha = ins.FechaDeInscripcion
                        });
                    }
                }
            }

            // Mostrar el reporte en el DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporte;
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Leer los archivos al iniciar el programa
            LeerAlumnos();
            LeerTalleres();
            LeerInscripciones();

            // Cargar alumnos en el ComboBox
            comboBoxAlumno.DataSource = alumnos;
            comboBoxAlumno.DisplayMember = "Nombre";

            // Cargar talleres en el ComboBox
            comboBoxTaller.DataSource = talleres;
            comboBoxTaller.DisplayMember = "NombreDelTaller";
        }

        // Botón para inscribir un alumno a un taller
        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            // Obtener el alumno y taller seleccionados
            Alumno alumno = (Alumno)comboBoxAlumno.SelectedItem;
            Taller taller = (Taller)comboBoxTaller.SelectedItem;

            // Crear nueva inscripción
            Inscripcion inscripcion = new Inscripcion();

            inscripcion.DpiDelEstudiante = alumno.Dpi;
            inscripcion.CodigoDelTaller = taller.CodigoDelTaller;

            // La fecha se asigna automáticamente con la fecha actual
            inscripcion.FechaDeInscripcion = DateTime.Now;

            // Agregar a la lista de inscripciones
            inscripciones.Add(inscripcion);

            // Guardar en el archivo
            GuardarInscripcion();

            // Actualizar el reporte
            MostrarReporte();
        }

        // Botón para mostrar el reporte manualmente
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        // Botón para ordenar los talleres alfabéticamente
        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenar la lista de talleres por nombre
            talleres = talleres.OrderBy(t => t.NombreDelTaller).ToList();
            MostrarReporte();
        }
    }
}

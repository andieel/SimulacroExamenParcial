using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroExamenParcial
{
    internal class Inscripcion
    {
        string dpiDelEstudiante;
        string codigoDelTaller;
        DateTime fechaDeInscripcion;

        public string DpiDelEstudiante { get => dpiDelEstudiante; set => dpiDelEstudiante = value; }
        public string CodigoDelTaller { get => codigoDelTaller; set => codigoDelTaller = value; }
        public DateTime FechaDeInscripcion { get => fechaDeInscripcion; set => fechaDeInscripcion = value; }
    }
}

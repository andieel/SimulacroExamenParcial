using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroExamenParcial
{
    internal class Taller
    {
        string codigoDelTaller;
        string nombreDelTaller;
        decimal costo;

        public string CodigoDelTaller { get => codigoDelTaller; set => codigoDelTaller = value; }
        public string NombreDelTaller { get => nombreDelTaller; set => nombreDelTaller = value; }
        public decimal Costo { get => costo; set => costo = value; }
    }
}

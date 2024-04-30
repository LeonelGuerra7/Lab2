using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class Nomina
    {
        private int diasLaborados;
        private int asigDias;
        public int DiasLaborados { get; set; }
        public int AsigDias { get; set; }
        public decimal CalcularNomina (int diasLab, decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            return totalSalario;
        }  
    }
}

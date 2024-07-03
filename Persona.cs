using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LINQpt2
{
    [DebuggerDisplay("(nombre)")]
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Soltero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        public List<string> Telefonos = new List<string>();
        public int Empresald { get; set; }
    }
}
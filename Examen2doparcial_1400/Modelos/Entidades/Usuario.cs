using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doparcial_1400.Modelos.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string ChequeoGeneral { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doparcial_1400.Modelos.Entidades
{
    public class Estados
    {
        public int Id { get; set; }
        public bool SinResolver { get; set; }
        public bool Espera { get; set; }
        public bool Cerrado { get; set; }
        public bool Abierto { get; set; }

    }
}

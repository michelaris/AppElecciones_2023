using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Resultado
    {
        public int IdResultado { get; set; }
        public int IdCandidato { get; set; }
        public int PorcentajeVotos { get; set; }
        public int IdEleccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Resultado()
        {

        }

    }
}

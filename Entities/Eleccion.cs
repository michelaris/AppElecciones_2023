using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Eleccion
    {
        public int IdEleccion { get; set; }
        public string Descripcion { get; set; }
        public string Cargo { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaVotacion { get; set; }
        public int IdUsuario { get; set; }
        public byte[] Foto { get; set; }

        public Eleccion()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Candidato
    {
        public int IdCandidato { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Mensaje { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public int IdEleccion { get; set; }

        public Candidato()
        {
                
        }

    }
}

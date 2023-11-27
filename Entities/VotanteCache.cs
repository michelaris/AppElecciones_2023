using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class VotanteCache
    {
        public static int IdVotante { get; set; }
        public static string DocumentoIdentidad { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static bool Activo { get; set; }
        public static DateTime FechaRegistro { get; set; }
        public static bool EmitioVotacion { get; set; }
        public static int IdEleccion { get; set; }
        public static int IdUsuario { get; set; }
    }
}

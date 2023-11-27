using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsuarioCache
    {
        public static int IdUSuario { get; set; }
        public static string DocumentoIdentidad { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string Correo { get; set; }
        public static string LoginName { get; set; }
        public static string Password { get; set; }
        public static bool Activo { get; set; }
        public static string Rol { get; set; }
        public static byte[] Foto { get; set; }
    }
}

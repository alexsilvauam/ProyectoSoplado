using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoplado_1._0_.Modelo_de_datos.Usuario
{
    public class Miembro
    {
        public int IdentificacionUsuario { get; set; }
        public string RolUsuario { get; set; }
        public string NombreUsuario { get; set; }

        public string ApellidoUsuario { get; set; }
        public bool SolvenciaUsuario { get; set; }


        public Miembro(int identificacionUsuario, string rolUsuario, string nombreUsuario, string apellidoUsuario)
        {
            IdentificacionUsuario = identificacionUsuario;
            RolUsuario = rolUsuario;
            NombreUsuario = nombreUsuario;
            ApellidoUsuario = apellidoUsuario;
        }
    }
}

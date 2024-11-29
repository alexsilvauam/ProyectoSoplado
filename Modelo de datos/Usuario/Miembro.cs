using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoSoplado_1._0_.Modelo_de_datos.Usuario
{
    [Serializable]
    public class Miembro
    {
        public int IDusuario{ get; set; }
        public string RolUsuario { get; set; }
        public string CifCed { get; set; }
        public string Nombre { get; set; }

        public string Apellido{ get; set; }
        public int CodigoQR { get; set; }
        public bool Solvencia { get; set; }


        public Miembro(int idUsuario, string rolUsuario,  string nombre, string apellido, int codigoQR, string cifCed)
        {
            IDusuario = idUsuario;
            RolUsuario = rolUsuario;
            Nombre = nombre;
            Apellido = apellido;
            CodigoQR = codigoQR;
            CifCed = cifCed;
        }
    }
}

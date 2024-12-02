using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia
{
    [Serializable]
    public class Asistencia
    {
        public string NombreUsuario { get; set; }
        public DateTime FechaAcceso { get; set; }
        public string HoraAcceso { get; set; }

        public Asistencia(string nombreUsuario, DateTime fechaAcceso, string horaAcceso)
        {
            NombreUsuario = nombreUsuario;
            FechaAcceso = fechaAcceso;
            HoraAcceso = horaAcceso;
        }
    }
}

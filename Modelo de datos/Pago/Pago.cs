using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoplado_1._0_.Modelo_de_datos.Pago
{
    public class Pago
    {
        public int idMiembro { get; set; }
        public int id_pago { get; set; }
        public DateTime fecha_pago { get; set; }
        public double monto_pago { get; set; }
    }
}

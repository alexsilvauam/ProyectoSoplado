﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoplado_1._0_.Modelo_de_datos.Asistencia
{
    public class Asistencia
    {
        public string CedulaAsistencia { get; set; }
        public DateTime FechaAcceso { get; set; }
        public string HoraAcceso { get; set; }
        public bool EstadoEntrada { get; set; }

        public Asistencia(string cedulaAsistencia, DateTime fechaAcceso, string horaAcceso)
        {
            CedulaAsistencia = cedulaAsistencia;
            FechaAcceso = fechaAcceso;
            HoraAcceso = horaAcceso;
        }
    }
}
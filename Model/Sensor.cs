using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoSAT.Model
{
    public class Sensor
    {

        public Object _id { get; set; }
        public string nombre { get; set; }
        public string dato { get; set; }
        public string tipoMedicion { get; set; }
        public string nodo { get; set; }
        public string estacion { get; set; }
        public string token { get; set; }

    }
}

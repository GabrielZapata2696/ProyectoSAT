using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoSAT.Model
{
    public class Administrador
    {
        public Object _id { get; set; }
        public string username { get; set; }
        public string clave { get; set; }
        public string correo { get; set; }
        public string token { get; set; }
    }
}

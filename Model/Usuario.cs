using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoSAT.Model
{
    public class Usuario
    {

        public Object _id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string numTelefonico { get; set; }
        public string ubicacion { get; set; }
        public string token { get; set; }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoSAT.Data;
using ProyectoSAT.Model;

namespace ProyectoSAT.Controller
{
    //[Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private static Random random = new Random();

        [HttpGet]
        [Route("ListarUsuarios")]
        public string Buscar_ListadoUsuarios()
        {
            DAOUsuario daoUser = new DAOUsuario();
            return daoUser.Consultar_ListadoUsuarios();
        }

        [HttpPost]
        [Route("IngresarUsuario")]
        public string Ingresar_Usuario(Usuario contenido)
        {
            try
            {                             
                DAOUsuario daoUser = new DAOUsuario();
                Object id = RandomId(24);
                return daoUser.InsertUsuario(contenido, id);
            }
            catch (ArgumentNullException nullEx)
            {
                return "La informacion a ingresar esta incompleta, error: " + nullEx;
            }


        }

        private Object RandomId(int longitud)
        {
            string strFinal = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            return new string(Enumerable.Repeat(strFinal, longitud).Select(x => x[random.Next(x.Length)]).ToArray());
        }
    }
}

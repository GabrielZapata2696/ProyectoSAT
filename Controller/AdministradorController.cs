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
    public class AdministradorController : ControllerBase
    {
        [HttpGet]
        [Route("ObtenerAdministrador")]
        public string Buscar_Administrador()
        {
            DAOAdministrador daoAdmin = new DAOAdministrador();
            return daoAdmin.Consultar_Administrador();
        }




       

    }
}

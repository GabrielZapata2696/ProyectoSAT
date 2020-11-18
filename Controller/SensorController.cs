using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Newtonsoft.Json;
using ProyectoSAT.Data;
using ProyectoSAT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoSAT.Controller
{
    //[Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private static Random random = new Random();


        [HttpGet]
        [Route("ListarSensores")]
        public string Buscar_ListadoSensores()
        {
            DAOSensor daoSensor = new DAOSensor();
            return daoSensor.Consultar_ListadoSensores();
        }

        [HttpPost]
        [Route("IngresarSensor")]
        public string Ingresar_Sensor(Sensor contenido)
        {
            try
            {
                //Sensor sensor = JsonConvert.DeserializeObject<Sensor>(contenido);               
                DAOSensor daoSensor = new DAOSensor();
                Object id = RandomId(24); 
                return daoSensor.InsertSensor(contenido, id);
            }
            catch (ArgumentNullException nullEx)
            {
                return "La informacion a ingresar esta incompleta, error: "+nullEx;
            }


        }
        



        private Object RandomId(int longitud)
        {
            string strFinal = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            return new string(Enumerable.Repeat(strFinal, longitud).Select(x => x[random.Next(x.Length)]).ToArray());
        }


    }
}

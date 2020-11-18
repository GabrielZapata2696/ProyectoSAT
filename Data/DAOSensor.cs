using ProyectoSAT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace ProyectoSAT.Data
{
    public class DAOSensor
    {
        public string InsertSensor(Sensor contenido, Object id)
        {
            Connection();
            MongoHelper.sensor_Coleccion.InsertOneAsync(new Sensor
            {
                _id = id,
                nombre = contenido.nombre,
                dato = contenido.dato,
                tipoMedicion = contenido.tipoMedicion,
                estacion = contenido.estacion,
                nodo = contenido.nodo,
                token = contenido.token
            });

            return "Sensor ingresado satisfactoriamente";

        }

        public string Consultar_ListadoSensores()
        {
            Connection();
            var filtro = Builders<Sensor>.Filter.Ne("_id", "");
            var resultado = MongoHelper.sensor_Coleccion.Find(filtro).ToList();

            return (JsonConvert.SerializeObject((List<Sensor>)resultado)).ToString();
        }


        private void Connection()
        {
            MongoHelper.ConnectToMongoService();
            MongoHelper.sensor_Coleccion = MongoHelper.database.GetCollection<Sensor>("sensor");
        }


    }
}

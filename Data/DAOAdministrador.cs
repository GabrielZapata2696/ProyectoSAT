using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Newtonsoft.Json;
using ProyectoSAT.Model;


namespace ProyectoSAT.Data
{
    public class DAOAdministrador
    {
        public string Consultar_Administrador()
        {
            Connection();
            var filtro = Builders<Administrador>.Filter.Ne("_id", "");
            var resultado = MongoHelper.Administrador_Coleccion.Find(filtro).ToList();

            return (JsonConvert.SerializeObject((List<Administrador>)resultado)).ToString();
        }

        private void Connection()
        {
            MongoHelper.ConnectToMongoService();
            MongoHelper.Administrador_Coleccion = MongoHelper.database.GetCollection<Administrador>("Administrador");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Newtonsoft.Json;
using ProyectoSAT.Model;

namespace ProyectoSAT.Data
{
    public class DAOUsuario
    {
         public string Consultar_ListadoUsuarios()
        {
            Connection();
            var filtro = Builders<Usuario>.Filter.Ne("_id", "");
            var resultado = MongoHelper.usuarios_Coleccion.Find(filtro).ToList();

            return (JsonConvert.SerializeObject((List<Usuario>)resultado)).ToString();
        }


        public string InsertUsuario(Usuario contenido, Object id)
        {
            Connection();
            MongoHelper.usuarios_Coleccion.InsertOneAsync(new Usuario
            {
                _id = id,
                username = contenido.username,
                email = contenido.email,
                password = contenido.password,
                numTelefonico = contenido.numTelefonico,
                ubicacion = contenido.ubicacion,
                token = contenido.token
            });

            return "Usuario ingresado satisfactoriamente";

        }



        private void Connection()
        {
            MongoHelper.ConnectToMongoService();
            MongoHelper.usuarios_Coleccion = MongoHelper.database.GetCollection<Usuario>("usuario");
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ProyectoSAT.Model
{
    public class MongoHelper
    {
        
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }

        public static string MongoConnection = "mongodb+srv://SAT:SAT2020.@cluster0.esnwa.mongodb.net/SATdb?retryWrites=true&w=majority";

        public static string MongoDatabase = "SATdb";     
        public static IMongoCollection<Usuario> usuarios_Coleccion { get; set; }
        public static IMongoCollection<Sensor> sensor_Coleccion { get; set; }
        public static IMongoCollection<Administrador> Administrador_Coleccion { get; set; }
      

        internal static void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                throw;
            }
        }


    }
}

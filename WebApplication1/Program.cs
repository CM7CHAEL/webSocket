using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wbserver.Models;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("prueba");

            var pruebaDB = database.GetCollection<@Base>("base");

            var baseObject = new Base() { Nombre = "Base 03" };
            //pruebaDB.InsertOne(baseObject);  
            //List<Base> lst = pruebaDB.Find(d => true).ToList();


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTICurso1.Models;
using Newtonsoft.Json;

namespace TareaTICurso1
{
    class Program
    {
        static void Main(string[] args)
        {
            dbPruebaCursoEntities db = new dbPruebaCursoEntities();
            DCBanco consulta = new DCBanco();

            List<DCBanco> ListaBanco = db.DCBanco.ToList();
            List<DCBanco> listado = new List<DCBanco>();

            ////foreach (DCBanco item in ListaBanco)
            ////{
            ////    Console.WriteLine("IdBanco= " + item.IdBanco);
            ////    Console.WriteLine("TasaInteres= " + item.TasaInteres);
            ////    Console.WriteLine("Cantidad= " + item.Cantidad);
            ////    Console.WriteLine("Finaciado Por = " + item.DCCarro.FinanciadoPor);
            ////    Console.WriteLine("Marca = " + item.DCCarro.Marca);
            ////    Console.WriteLine("Modelo = " + item.DCCarro.Modelo);
            ////    Console.WriteLine("Año = " + item.DCCarro.Año);

    
            ////}


            var datos = (from banco in ListaBanco // db.DCBanco
                         join carro in db.DCCarro
                         on banco.IdBanco equals carro.FinanciadoPor

                         select new
                         {
                             CodigoBanco = banco.IdBanco,
                             TasaInteres = banco.TasaInteres,
                             Cantidad = banco.Cantidad,
                             FinanciadoPor = carro.FinanciadoPor,
                             Marca = carro.Marca,
                             Modelo = carro.Modelo,
                             Año = carro.Año

                         }

                       ).ToList();


            var bancod = new DCBanco();

            foreach (var item in datos)
            {
                DCBanco listaT = new DCBanco();
                listaT.IdBanco = item.CodigoBanco;
                listaT.TasaInteres = item.TasaInteres;
                listaT.Cantidad = item.Cantidad;

              listado.Add(listaT);
            }


            var Json = Newtonsoft.Json.JsonConvert.SerializeObject(listado,
                            Newtonsoft.Json.Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });


            Console.WriteLine(Json);

            // antes

            Console.ReadLine();
        }
    }
}

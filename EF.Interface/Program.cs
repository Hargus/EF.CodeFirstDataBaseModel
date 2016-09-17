using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.DataAccess.Models;

namespace EF.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //var context = new EF.DataAccess.Models.NORTHWNDContext();

            //var result = context.Employees.FirstOrDefault();

            //Console.WriteLine(result.FirstName);
            //Console.ReadLine();

            //result.FirstName = "Jose";
            //context.SaveChanges();

            //var resultUpdated = context.Employees.FirstOrDefault();

            //Console.WriteLine(resultUpdated.FirstName);
            //Console.ReadLine();

            using (var ctx = new NORTHWNDContext())
            {
                DataAccess.Models.Territory e = new DataAccess.Models.Territory() { TerritoryID = "98107", TerritoryDescription = "Hargus Inserted2", RegionID = 1};

                ctx.Territories.Add(e);
                ctx.SaveChanges();

                var res = ctx.Territories.Select(x => x.TerritoryDescription);
                ;

                Console.WriteLine(res);
                Console.ReadLine();
            }



        }
    }
}


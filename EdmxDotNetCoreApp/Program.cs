using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Xml;

namespace EdmxDotNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Entities())
            {
                db.Database.CreateIfNotExists();
                Console.WriteLine(db.People.Include(p=>p.Things).Count());
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace abstractclassintro
{
    class Program
    {
        static void Main(string[] args)
        {
            List <DataAccess> databases=new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };
            foreach(var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("db"));
            }
            Console.ReadKey();


        }
    }
}

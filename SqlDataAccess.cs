using System;
namespace abstractclassintro
{
    public class SqlDataAccess:DataAccess
    {
        public override  void LoadData(string sql)
        {
            Console.WriteLine("Loading Sql data");
        }
        public override void SaveData(string sql)
        {
             Console.WriteLine("Saving Sql data");
        }
    }
}
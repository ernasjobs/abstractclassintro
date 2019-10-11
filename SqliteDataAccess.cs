using System;
namespace abstractclassintro
{
    public class SqliteDataAccess:DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output=base.LoadConnectionString(name);
            output+="(from Sqlite)";
            return output;

        }
        public override  void LoadData(string sql)
        {
            Console.WriteLine("Loading Sqlite data");
        }
        public override void SaveData(string sql)
        {
             Console.WriteLine("Saving Sqlite data");
        }
    }
}
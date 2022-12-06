using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace sqlScript2
{
    public class Program
    {
         static string path = ""; // érdemes "copy always" módon bemásolni az output könyvtárba!
         static string dbName = ""; // a létrehozott tábla neve
        //public static int propCount = 0;
        static void Main(string[] args)
        {
            //Console.Write("Jellemzők (oszlopok) száma: ");

            if (path == "" || dbName == "") Console.WriteLine("először állíts be elérési utat a txt-hez és táblanevet! (Program.cs 10-11. sor )");
            else Insert(path);
        }
        static void Insert(string path) 
        {
            List<Table> data = new List<Table>();
            List<Table> firstLine = new List<Table>();           
            foreach (var item in File.ReadAllLines(path).Skip(1))
            {
                data.Add(new Table(item));
            }
            firstLine.Add(new Table(File.ReadAllLines(path)[0]));



            List<string> sql = new List<string>();
            sql.Add($"INSERT INTO {dbName} VALUES");
            foreach (var item in data)
            {
                if(int.Parse(item.id) != data.Count)
                {
                    sql.Add($"({item.id}, '{item.prop1}', '{item.prop2}'),");
                }
                else sql.Add($"({item.id}, '{item.prop1}', '{item.prop2}');"); //utolsó insert
            }
            File.WriteAllLines($"{dbName}.sql", sql);
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sqlScript2
{
    public class Program
    {
        private static string path = GetPath();
        static string dbName = "";
        private static int propCount = GetPropCount(path);
        [STAThread]
        static void Main(string[] args)
        {
            Console.Write("Adja meg a létrehozandó tábla nevét: "); //TODO: hiba ellenőrzés, regex
            dbName = Console.ReadLine();

            Console.WriteLine("Válassza ki a txt fájl elérési útját!");
            System.Threading.Thread.Sleep(2000);



            if (path == "" || dbName == "") Console.WriteLine("először állíts be elérési utat a txt-hez és táblanevet! (Program.cs 10-11. sor )");
            else Insert(path);
        }
        static int GetPropCount(string path)
        {
            string line = File.ReadAllLines(path).First();
            int count = line.Split(';').Count();

            return count;
        }
        static string GetPath() //TODO: txt fájl-t választott-e
        {
            string path = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            return path;
        }
        static void Insert(string path) 
        {
            List<Table> data = new List<Table>();
            string[] m;
            List<string> sql = new List<string>();
            sql.Add($"INSERT INTO {dbName} VALUES");
            if (propCount == 3) //3prop
            {
               
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(';');
                    data.Add(new Table(m[0], m[1], m[2]));
                }

                foreach (var item in data)
                {
                    if (item.ID != data.Last().ID)
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}');"); //utolsó insert
                }
                File.WriteAllLines($"{dbName}.sql", sql);
            }
            if (propCount == 4) //4prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(';');
                    data.Add(new Table(m[0], m[1], m[2], m[3]));
                }

                foreach (var item in data)
                {
                    if (item.ID != data.Last().ID)
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}');");
                }
                File.WriteAllLines($"{dbName}.sql", sql);
            }
            if (propCount == 5) //5prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(';');
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4]));
                }

                foreach (var item in data)
                {
                    if (item.ID != data.Last().ID)
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}');");
                }
                File.WriteAllLines($"{dbName}.sql", sql);
            }




            
        }
        
    }
}

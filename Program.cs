using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sqlScript2
{
    public class Program
    {
        static string dbName = SetName();
        static string seperator = GetSeperator();
        private static string path = GetPath();
        private static int propCount = GetPropCount(path);
        [STAThread]
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(2000);

            Insert(path);
        }
        static string GetSeperator()
        {
            Console.Write("Adja meg a szeparátor karaktert (alapértelmezett: tabulátor), alapértelmezett esetén hagyja üresen: ");

            string sep = Console.ReadLine();
            string result = "\t";

            if(sep == "") return result;
            if (sep == "\t" || sep == ";") result = sep;
            else
            {
                Console.WriteLine("Érvénytelen szeparátor!");
                GetSeperator();
            };

            return result;
        }
        static int GetPropCount(string path)
        {
            string line = File.ReadAllLines(path).First();
            int count = line.Split(seperator).Count();

            return count;
        }
        static string SetName()
        {
            Console.Write("Adja meg a létrehozandó tábla nevét: ");
            dbName = Console.ReadLine();

            if (dbName != "") return dbName;
            else
            {
                Console.WriteLine("Először állítson be táblanevet!");
                SetName();
                return null;
            }
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
            firstLineInsert(sql);
            if (propCount == 2) //2prop
            {

                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}');");
                }
            }
            if (propCount == 3) //3prop
            {
               
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}');"); //utolsó insert
                }
            }
            if (propCount == 4) //4prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}');");
                }
            }
            if (propCount == 5) //5prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}');");
                }
            }
            if (propCount == 6) //6prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4], m[5]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}');");
                }
            }
            if (propCount == 7) //7prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4], m[5], m[6]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}');");
                }
            }
            if (propCount == 8) //8prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4], m[5], m[6], m[7]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}', '{item.P7}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}', '{item.P7}');");
                }
            }
            if (propCount == 9) //9prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4], m[5], m[6], m[7], m[8]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}', '{item.P7}', '{item.P8}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}', '{item.P7}', '{item.P8}');");
                }
            }
            if (propCount == 10) //10prop
            {
                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(seperator);
                    data.Add(new Table(m[0], m[1], m[2], m[3], m[4], m[5], m[6], m[7], m[8], m[9]));
                }

                foreach (var item in data)
                {
                    if (item != data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}', '{item.P7}', '{item.P8}', '{item.P9}'),");
                    }
                    else sql.Add($"({item.ID}, '{item.P1}', '{item.P2}', '{item.P3}', '{item.P4}', '{item.P5}', '{item.P6}', '{item.P7}', '{item.P8}', '{item.P9}');");
                }
            }
            Saving(sql);

            
        }
        static void Saving(List<string> sql) // fájl mentési helye 
        {
            SaveFileDialog sv = new SaveFileDialog();
            string path = "";
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fb.SelectedPath);
                path = fb.SelectedPath;
            }

            sv.InitialDirectory = path;
            sv.RestoreDirectory = true;

            File.WriteAllLines($"{sv.InitialDirectory}/{dbName}.sql", sql);
        }
        static void firstLineInsert(List<string> sql)
        {
            string[] fLine = File.ReadAllLines(path)[0].Split(';');
            string pattern = "";
            foreach (var item in fLine)
            {
                if(item == fLine.Last()) pattern += $"{item}";
                else pattern += $"{item},";
            }
            sql.Add($"INSERT INTO {dbName}({pattern}) VALUES");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace sqlScript2
{
    public class Table
    {
        public string id { get; private set; }
        public string prop1 { get; private set; }
        public string prop2 { get; private set; }


        //public string prop3 { get; private set; }
        //public string prop4 { get; private set; }
        //public string prop5 { get; private set; }

        
         
        public Table(string line)  //TODO: +line pm -> variálható propCount
        {
            string[] m = line.Split(';');
            if(m.Length == 3)
            {
                id = m[0];
                prop1 = m[1];
                prop2 = m[2];
                //prop3 = m[3];
                //prop4 = m[4];
                //prop5 = m[5];
            }
            else Console.WriteLine("Módosítani kell a jellemzők számát! (Table.cs)");
        }
        //Több jellemmzőnél csak töröld ki a kommenteket
    }
}

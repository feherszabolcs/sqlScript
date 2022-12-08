using System;
using System.Collections.Generic;
using System.Text;

namespace sqlScript2
{
    public class Table //10
    {
        public string ID { get; private set; }
        public string P1 { get; private set; }
        public string P2 { get; private set; }


        public string P3 { get; private set; }
        public string P4 { get; private set; }
        public string P5 { get; private set; }
        public string P6 { get; private set; }
        public string P7 { get; private set; }
        public string P8 { get; private set; }
        public string P9 { get; private set; }
        //TODO up to 10



        public Table(string id,string prop1, string prop2) 
        {
           ID = id;
           P1 = prop1;
           P2 = prop2;
        }
        public Table(string id, string prop1, string prop2, string prop3)
        {
            ID = id;
            P1 = prop1;
            P2 = prop2;
            P3 = prop3;
        }
        public Table(string id, string prop1, string prop2, string prop3, string prop4)
        {
            ID = id;
            P1 = prop1;
            P2 = prop2;
            P3 = prop3;
            P4 = prop4;
        }
        public Table(string id, string prop1, string prop2, string prop3, string prop4, string prop5)
        {
            ID = id;
            P1 = prop1;
            P2 = prop2;
            P3 = prop3;
            P4 = prop4;
            P5 = prop5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employer
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public int Kor { get; set; }
        public int Kereset { get; set; }

        public Employer(string row)
        {
            string[] darabol = row.Split(';');

            Azonosito = int.Parse(darabol[0]);
            Nev = darabol[1];
            Kor = int.Parse(darabol[2]);
            Kereset = int.Parse(darabol[3]);
        }
    }

}

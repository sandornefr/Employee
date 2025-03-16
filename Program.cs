using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        public static List<Employer> employers = new List<Employer>();

        public static void feladat3()
        {
            Console.WriteLine("Az összes dolgozó neve: ");
            foreach (var item in employers)
            {
                Console.WriteLine(item.Nev);
            }
        }

        public static void feladat4()
        {
            int max = employers[0].Kereset;
            int id = 0;

            foreach (var item in employers)
            {
                if (item.Kereset > max)
                {
                    max = item.Kereset;
                    id = item.Azonosito;
                }
            }

            Console.WriteLine($"A legjobban kereső dolgozó azonosítója: {id}, neve: {employers[id - 1].Nev}");
        }

        public static void feladat5()
        {
            Console.WriteLine("Nyugdíj előtt állók:");
            foreach (var item in employers)
            {
                if (item.Kor==55)
                {
                    Console.WriteLine($"Neve: {item.Nev}, kora: {item.Kor}");
                }
            }
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");

            for (int i = 0; i < 100; i++)
            {
                Employer emp = new Employer(sr.ReadLine());
                employers.Add(emp);
            }

            feladat3();
            feladat4();
            feladat5();
        }
    }
}

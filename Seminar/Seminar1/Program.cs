using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(10, "Grivei", 7.5f);
            Animal a2 = new Animal(5, "Azorel", 5.6f);
            Urs u1 = new Urs(true, 12, "Baloo", 145.0f);
            Pinguin p1 = new Pinguin(true, 12, "Ping", 12.0f);


            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(u1);
            Console.WriteLine(p1);

            Zoo z1 = new Zoo();

            z1.Lista.Add(u1.Clone());
            z1.Lista.Add(a1.Clone());
            z1.Lista.Add(a2.Clone());
            z1.Lista.Add(p1.Clone());

            u1.Nume = "URS MODIFICAT";

            foreach(Animal a in z1.Lista) 
                Console.WriteLine(a.ToString());

            Zoo z2 = z1.Clone();

            u1.Nume = "URS MODIFICAT";

            Console.WriteLine();

            z1.Lista.Sort();
            foreach (Animal a in z2.Lista)
                Console.WriteLine(a.ToString());

            Console.Read();

        }
    }
}

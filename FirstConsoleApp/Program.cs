using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Marek";
            string name2 = "Ania";

            //komentarz jednolinijkowy

            /*komenatrz dlugi
            */

            Console.WriteLine(name1);

            Console.WriteLine("Imie nr 1 to: {0}", name1);

            Console.WriteLine($"Imie nr 1 to: {name1}");

            Console.WriteLine("Tekst i cudzyslow w srodku: \"tak jak tutaj\" ");

            Console.ReadLine();

            double x = 2.3;
            float y = 1.1f;
            float z = 3.9F;
            Console.WriteLine("wartosc x= {0}", x);
            Console.WriteLine("wartosc y= {0}", y);
            Console.WriteLine("wartosc z= {0}", z);

            string s = Convert.ToString(z);
            Console.WriteLine("wartosc s= {0}", s);

            Console.ReadLine();
        }
    }
}

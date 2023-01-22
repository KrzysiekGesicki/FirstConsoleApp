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

            /*komentarz dlugi
            */
            /*
            Console.WriteLine(name1);

            Console.WriteLine("Imie nr 1 to: {0}", name1);

            //String interpolation:
            Console.WriteLine($"Imie nr 2 to: {name2}");

            Console.WriteLine("Tekst i cudzyslow w srodku: \"tak jak tutaj\" ");

            Console.WriteLine($"Hello {name2.ToUpper()}");

            Console.WriteLine($"Imie nr 2 to: '{name2}' i ma {name2.Length} litery");

            Console.ReadLine();

            var names = new[] { "Asia", "Adolf", "Silvio" };
            foreach (var name in names )
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

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

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.ReadLine();

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.ReadLine();

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            Console.ReadLine();

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.ReadLine();

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.ReadLine();

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.ReadLine();

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
            Console.ReadLine();

            double maxx = double.MaxValue;
            double minn = double.MinValue;
            Console.WriteLine($"The range of double is {minn} to {maxx}");
            Console.ReadLine();

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            Console.ReadLine();

            decimal minnn = decimal.MinValue;
            decimal maxxx = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {minnn} to {maxxx}");
            Console.ReadLine();

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            Console.ReadLine();
            
            Console.WriteLine("Obliczanie pola okregu - podaj promien");
            double r = Convert.ToDouble(Console.ReadLine());
            double P = Math.PI * r*r;
            Console.WriteLine($"Pole wynosi: {P}");
            Console.ReadLine();

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            

            int sum = 0;

            for (int i = 1;i <= 20; i++)
            {
                if (i%3==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Suma wynosi: {sum}");

            Console.ReadLine();
            

            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            */

            var fibonacciNumbers = new List<int>{};

            for (int i = 1;i <= 20; i++)
            {
                if (i<3)
                {
                    fibonacciNumbers.Add(1);
                }
                else 
                {
                    fibonacciNumbers.Add(fibonacciNumbers[fibonacciNumbers.Count - 1] + fibonacciNumbers[fibonacciNumbers.Count - 2]);
                }
            }
            int licznik = 1;
            foreach (int j in fibonacciNumbers)
            {
                Console.WriteLine($"{licznik} wyraz ciągu Fibonacciego wynosi: {j}");
                licznik++;
            }
                
            Console.ReadLine();


        }
    }
}

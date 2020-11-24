using System;
using System.Diagnostics;

namespace Laengste_Reihe_bis_eine_Million
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("Bitte eine Zahl eingeben: ");
            long x = long.Parse(Console.ReadLine());
            stopWatch.Start();
            long n;
            long n2;
            long n3 = 0;
            long laengeALT = 0;
            long laengeNEU;

            for (n = 1; n < x; n++)
            {
                laengeNEU = 0;
                for (n2 = n; n2 >= 1;)
                {
                    if (n2 == 1)
                    {
                        laengeNEU++;
                        break;
                    }
                    n2 = (n2 % 2 == 0) ? n2 / 2 : (3 * n2) + 1;
                    laengeNEU++;

                 
                }
                
                if (laengeNEU > laengeALT)
                {
                    n3 = n;
                    laengeALT = laengeNEU;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("\nDauer: " + stopWatch.ElapsedMilliseconds + "ms");
            Console.WriteLine("Startzahl: " + n3);
            Console.WriteLine("Zahlen insgesamt: " + laengeALT);
        }
    }
}

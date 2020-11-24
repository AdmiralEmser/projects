using System;
using System.Diagnostics;

namespace Alle_Primzahlen_summiert_bis_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Int64 AnzahlPrimzahlen = 0;
            Int64 i;
            Int64 geteiltDurch;
            Int64 ergebnis;
            Int64 auszaehlungCounter = 0;
            Int64 loesung = 2;
            Int64 WurzelAusAnzahlPrimzahlen;
            Console.Write("Bitte eine Ganzzahl (größer als 1) eingeben, um das obere Ende des Zahlenbereiches zu definieren: ");
            Int64 angegebeneZahl = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Identifiziere und addiere alle Primzahlen im Bereich von 0 bis " + (angegebeneZahl - 1) + "...");
            stopWatch.Start();
            Int64[] Primzahlen = new Int64[angegebeneZahl];

            if (angegebeneZahl < 2)
            {
                Console.WriteLine("Keine Primzahlen vorhanden oder nicht im Programm integriert.");
            }
            else
            {
                for (i = 3; i < angegebeneZahl; i += 2)
                {
                    //Blabla
                    ergebnis = 0;
                    WurzelAusAnzahlPrimzahlen = (Int64)Math.Sqrt(AnzahlPrimzahlen);

                    for (geteiltDurch = 0; geteiltDurch < WurzelAusAnzahlPrimzahlen; geteiltDurch++)
                    {
                        if (i % Primzahlen[geteiltDurch] == 0)
                        {
                            ergebnis = 1;
                            break;
                        }
                    }
                    if (ergebnis == 0)
                    {
                        Primzahlen[AnzahlPrimzahlen] = i;
                        AnzahlPrimzahlen++;
                    }
                }
                while (auszaehlungCounter < AnzahlPrimzahlen)
                {
                    loesung = loesung + Primzahlen[auszaehlungCounter];
                    auszaehlungCounter++;
                }
                stopWatch.Stop();
                Console.WriteLine("\nAlle Primzahlen bis " + (angegebeneZahl - 1) + " addiert: " + loesung);
                Console.WriteLine("\nAnzahl der Primzahlen bis unter " + (angegebeneZahl - 1) + ": " + (AnzahlPrimzahlen + 1));
                Console.WriteLine("Dauer in ms: " + stopWatch.ElapsedMilliseconds + " Millisekunden.");
                Console.ReadLine();
            }
        }
    }
}
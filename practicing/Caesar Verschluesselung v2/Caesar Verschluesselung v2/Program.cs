using System;
using System.Diagnostics;

namespace Caesar_Verschluesselung_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Bitte ein Wort angeben: ");
            string Eingabe = Console.ReadLine();
            Console.WriteLine("\nWert, um den das Wort verschoben werden soll: ");
            long Verschiebungswert = long.Parse(Console.ReadLine());
            if ((Verschiebungswert > 0) && (Verschiebungswert < 26))
            {
                stopWatch.Start();
                char[] EingabeChar = Eingabe.ToCharArray();
                char[] AusgabeChar = new char[EingabeChar.Length];
                long x;
                string Ausgabe = "";

                for (x = 0; x < EingabeChar.Length; x++)
                {
                    AusgabeChar[x] = Verschluesseln(EingabeChar[x], Verschiebungswert);
                }
                for (int i = 0; i < AusgabeChar.Length; i++)
                {
                    Ausgabe += AusgabeChar[i].ToString();
                }
                stopWatch.Stop();
                Console.WriteLine("\nVerschluesselt: " + Ausgabe);
                Console.WriteLine("Dauer: " + stopWatch.ElapsedMilliseconds + "ms");
            }
            else
            {
                Console.WriteLine("Verschiebungen sind nur von 1 bis 25 moeglich.");
            }
            Console.WriteLine("\nFenster kann nun geschlossen werden.");
            Console.ReadLine();
        }

        public static char Verschluesseln(char zuVerschluesseln, long Wert)
        {
            long VerschiebungAuf;
            long Startposition;
            long x = zuVerschluesseln;

            if ((x > 96) && (x < 123))
            {
                char[] Alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Startposition = zuVerschluesseln - 97;

                VerschiebungAuf = Startposition + Wert;

                if (VerschiebungAuf > 25)
                {
                    VerschiebungAuf -= 26;
                }

                zuVerschluesseln = Alphabet[VerschiebungAuf];

                return zuVerschluesseln;
        }
            if ((x > 64) && (x< 91))
                {
                    char[] AlphabetGross = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                    Startposition = zuVerschluesseln - 65;

                    VerschiebungAuf = Startposition + Wert;

                    if (VerschiebungAuf > 25)
                    {
                        VerschiebungAuf -= 26;
                    }

                    zuVerschluesseln = AlphabetGross[VerschiebungAuf];

                    return zuVerschluesseln;
            }
            return zuVerschluesseln;
        }
    }
}





        // ACHTUNG! Methodennamen von "Verschluesseln" und "Entschluesseln" ausgetauscht, da es zuvor umgekehrt & falschherum war. Die Variablen tragen dennoch weiterhin dieselben Namen!





using System;
using System.Diagnostics;

namespace Vigenère_Verschluesselung
{
    class Program
    {
        public static long Skip;
        public static string SkipEverythingThatIsNoLetter;

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            string VerschluesselnOEntschluesseln;
            
            while (1 == 1)
            {
                long Break = 0;
                while (1 == 1)
                {
                    Console.WriteLine("Verschlüsseln ('v'), entschlüsseln ('e') oder beenden ('exit')?");
                    VerschluesselnOEntschluesseln = Console.ReadLine();
                    if ((VerschluesselnOEntschluesseln == "v") || (VerschluesselnOEntschluesseln == "e") || (VerschluesselnOEntschluesseln == "exit"))
                    {
                        if (VerschluesselnOEntschluesseln == "exit")
                        {
                            Break = 1;
                        }
                        break;
                    }
                }
                if (Break == 1)
                {
                    break;
                }

                while (1 == 1)
                {
                    Console.WriteLine("\nAlles außer Buchstaben überspringen ('y'/'n')?");
                    SkipEverythingThatIsNoLetter = Console.ReadLine();
                    if ((SkipEverythingThatIsNoLetter == "y") || (SkipEverythingThatIsNoLetter == "n"))
                    {
                        break;
                    }
                }

                if (VerschluesselnOEntschluesseln == "exit")
                {
                    break;
                }

                Console.Write("\nText: ");
                string Eingabe = Console.ReadLine();
                Console.Write("Schlüssel eingeben (nur kleine Buchstaben): ");
                char[] Verschiebungswert = Console.ReadLine().ToCharArray();

                stopWatch.Start();
                char[] EingabeChar = Eingabe.ToCharArray();
                char[] AusgabeChar = new char[EingabeChar.Length];
                long x;
                long y = 0;
                string Ausgabe = "";

                for (x = 0; x < EingabeChar.Length; x++)
                {
                    Skip = 0;
                    if (Verschiebungswert.Length == y)
                    {
                        y = 0;
                    }
                    if (VerschluesselnOEntschluesseln == "v")
                    {
                        AusgabeChar[x] = Verschluesseln(EingabeChar[x], Verschiebungswert[y] - 97);
                        y++;
                        if (Skip == 1)
                        {
                            y--;
                        }
                    }
                    if (VerschluesselnOEntschluesseln == "e")
                    {
                        AusgabeChar[x] = Entschluesseln(EingabeChar[x], Verschiebungswert[y] - 97);
                        y++;
                        if (Skip == 1)
                        {
                            y--;
                        }
                    }
                }
                for (int i = 0; i < AusgabeChar.Length; i++)
                {
                    Ausgabe += AusgabeChar[i].ToString();
                }
                stopWatch.Stop();
                Console.Write("\nVerschlüsselt: " + Ausgabe);
                Console.Write("\nDauer: " + stopWatch.ElapsedMilliseconds + "ms\n\n######################################################\n\n");
            }
        }

        private static char Verschluesseln(char zuEntschluesseln, long Wert)
        {
            long VerschiebungAuf;
            long Startposition;
            long x = zuEntschluesseln;

            if ((x > 96) && (x < 123))
            {
                char[] Alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Startposition = zuEntschluesseln - 97;

                VerschiebungAuf = Startposition - Wert;

                if (VerschiebungAuf < 0)
                {
                    VerschiebungAuf += 26;
                }

                zuEntschluesseln = Alphabet[VerschiebungAuf];

                return zuEntschluesseln;
            }
            if ((x > 64) && (x < 91))
            {
                char[] AlphabetGross = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                Startposition = zuEntschluesseln - 65;

                VerschiebungAuf = Startposition - Wert;

                if (VerschiebungAuf < 0)
                {
                    VerschiebungAuf += 26;
                }

                zuEntschluesseln = AlphabetGross[VerschiebungAuf];

                return zuEntschluesseln;
            }
            if (SkipEverythingThatIsNoLetter == "y")
            {
                Skip = 1;
            }
            return zuEntschluesseln;
        }

        public static char Entschluesseln(char zuVerschluesseln, long Wert)
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
            if ((x > 64) && (x < 91))
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
            if (SkipEverythingThatIsNoLetter == "y")
            {
                Skip = 1;
            }
            return zuVerschluesseln;
        }
    }
}

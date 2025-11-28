using System.Diagnostics;

namespace NevekSzurese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();

            nevek.Add("Kiss István");
            nevek.Add("Nagy elemér");
            nevek.Add("kissándorjózsef213");
            nevek.Add(" Tóth# Ilona");
            nevek.Add("Kovács Kristóf");

            while (true) {
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. Néveleji szóközök levágva");
                Console.WriteLine("2. Csak nagybetűvel kezdődők");
                Console.WriteLine("3. Csak számjegy nélküliek");
                Console.WriteLine("4. Csak speciális jel nélküliek");
                Console.WriteLine("5. Legalább egy szóközt tartalmazó");
                Console.WriteLine("6. Csak rendes nevek");
                string valaszt = Console.ReadLine();
                if (valaszt == "0")
                {
                    return;
                }
                else if (valaszt == "1")
                {
                    Console.Clear();
                    foreach (String nev in nevek)
                    {
                        Console.WriteLine(nev.TrimStart());
                    }
                }
                else if (valaszt == "2")
                {
                    Console.Clear();
                    foreach (String nev in nevek)
                    {
                        string[]darabok = nev.TrimStart().Split(' ');
                        bool jo = true;
                        foreach (String nevdarab in darabok)
                        {
                            //elemér
                            if (!char.IsUpper(nevdarab.TrimStart()[0]))
                                jo = false;
                        }
                        if (jo)
                        Console.WriteLine(nev.TrimStart());
                    }
                }
                else if (valaszt == "3")
                {
                    //Csak számjegy nélküliek
                    Console.Clear();
                    foreach(var nev in nevek)
                    {
                        bool jo = true;
                        foreach (char betu in nev)
                        {
                            if (char.IsNumber(betu))
                                jo = false;
                        }
                        if (jo)
                            Console.WriteLine(nev);
                    }
                }
                else if (valaszt == "4")
                {
                foreach (var nev in nevek)
                    {
                        bool jo = true;
                        foreach(char betu in nev)
                        {
                            if (!(char.IsLetterOrDigit(betu) || betu! == ' '))
                                    jo = false;
                        }
                        if (jo)
                            Console.WriteLine(nev);
                    }
                }
                else if (valaszt == "5")
                {
                    //5
                }
                else if (valaszt == "6")
                {
                    //6
                }
                else
                {
                    Console.WriteLine("Nincs ilyen parancs!");
                }
                Console.ReadKey();
            }
        }
    }
}

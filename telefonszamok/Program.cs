using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menukez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> telefonszamok = new List<string>();
            telefonszamok.Add("+36202275895");
            telefonszamok.Add("06203568987");
            telefonszamok.Add("(06)20/2558222");
            telefonszamok.Add("203568978+");
            telefonszamok.Add("nullahat202289578548");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 Kilépés");
                Console.WriteLine("1 Mindent megjelenít");
                Console.WriteLine("2 Csak a számjegyeket tartalmazók");
                Console.WriteLine("3 Csak a 12 hosszúak");
                Console.WriteLine("4 Csak számjegyeket és + jelet tartalmazhat");
                Console.WriteLine("5 Csak azok jelenjenek meg amiben 6-os szám van");
                Console.WriteLine("6 Csak számok és + jel, de csak elől lehet a +jel");
                Console.WriteLine("7 06-al kezdődik");
                Console.WriteLine("8 ( és vagy ) jel van benne");
                string valasz = Console.ReadLine();
                if (valasz == "0")
                {
                    return;
                }
                else if (valasz == "1")
                {
                    //1
                    Console.Clear();
                    foreach (string telefonszam in telefonszamok)
                    {
                        Console.WriteLine(telefonszam);
                    }
                }
                else if (valasz == "2")
                {
                    //2
                    Console.Clear();
                    foreach (var telefonszam in telefonszamok)
                    {
                        bool jo = true;
                        foreach (char betu in telefonszam)
                        {
                            if (!char.IsNumber(betu))
                            {
                                jo = false;
                            }
                        }
                        if (jo == true)
                        {
                            Console.WriteLine(telefonszam);
                        }
                    }
                }
                else if (valasz == "3")
                {
                    //3
                    Console.Clear();
                    foreach (var telefonszam in telefonszamok)
                    {
                        bool jo = false;
                        
                            if (telefonszam.Length==12)
                            {
                                jo = true;
                        }
                        if (jo == true)
                        {
                            Console.WriteLine(telefonszam);
                        }
                    }
                }
                else if (valasz == "4")
                {
                    //4
                }
                else if (valasz == "5")
                {
                    //5
                }
                else if (valasz == "6")
                {
                    //6
                }
                else if (valasz == "7")
                {
                    //7
                }
                else if (valasz == "8")
                {
                    //8
                }
                else
                {
                    Console.WriteLine("nincs ilyen parancs");
                }
                Console.ReadKey();
            }
        }
    }
}
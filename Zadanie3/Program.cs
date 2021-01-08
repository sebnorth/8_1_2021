using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0; // licznik literki 'a' lub 'A'
            int suma_w_linii = 0;
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj08012021\tekst.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);

            string s;
            while ((s = odczyt.ReadLine()) != null)
            {
                suma_w_linii = 0;
                Console.WriteLine(s);
                foreach (char znak in s)
                {
                    if (znak == 'a' || znak == 'A')
                    {
                        suma_w_linii++;
                        suma++;
                    }

                }
                Console.WriteLine("Suma literek 'a' lub 'A' w linii wynosi {0}", suma_w_linii);
                Console.WriteLine();
            }

            odczyt.Close();
            plik.Close();
            Console.WriteLine("Suma literek 'a' lub 'A' w pliku wynosi {0}", suma);
            Console.ReadKey();
        }
    }
}

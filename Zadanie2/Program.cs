using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zaj08012021\kwadrat.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Append, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    zapis.Write("*");
                }
                zapis.WriteLine();
            }

            zapis.Close();
            plik.Close();

            // Console.ReadKey();
        }
    }
}

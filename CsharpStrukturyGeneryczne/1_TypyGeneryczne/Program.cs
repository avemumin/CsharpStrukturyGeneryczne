using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
          
            WprowadzanieDanych(kolejka);

            PrzetwarzanieDanych(kolejka);
        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            var sum = 0.0;
            Console.WriteLine("W naszej kolejce jest :");

            while (!kolejka.JestPusty)
            {
                sum += kolejka.Czytaj();
                //   Console.WriteLine("\t\t" + kolejka.Czytaj());
            }

            Console.WriteLine(sum);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0d;
                var replaceCommaDot = Console.ReadLine();
                var wartoscWejsciowa = replaceCommaDot.Replace('.', ',');

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}

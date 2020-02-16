using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
          
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

            Console.WriteLine("W naszej kolejce jest :");

            while (!kolejka.JestPusty)
            {
                Console.WriteLine("\t\t" +kolejka.Czytaj());
            }




        }
    }
}

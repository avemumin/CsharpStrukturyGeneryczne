using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tablice
            Pracownik[] pracownicy = new Pracownik[]
            {
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Jan", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Tomek", Nazwisko = "Nowak"},
            };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < pracownicy.Length; i++)
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }

            //rozszerzenie wielkosci tablicy
            Array.Resize(ref pracownicy, 10);
            pracownicy[9] = new Pracownik { Imie = "Anatol", Nazwisko = "Koszyk" };


            //Listy

            List<Pracownik> pracownicyLista = new List<Pracownik>()
            {
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Jan", Nazwisko = "Nowak"},
                new Pracownik {Imie = "Tomek", Nazwisko = "Nowak"},
            };

            pracownicyLista.Add(new Pracownik { Imie = "Anna", Nazwisko = "Kos" });
            foreach (var pracownik in pracownicyLista)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < pracownicyLista.Count; i++)
            {
                Console.WriteLine(pracownicyLista[i].Imie + " " + pracownicyLista[i].Nazwisko);
            }

            var liczby = new List<int>();
            var pojemnosc = -1;

            while (!true)
            {
                if (liczby.Capacity != pojemnosc)
                {
                    pojemnosc = liczby.Capacity;
                    Console.WriteLine(pojemnosc);
                }
                liczby.Add(1);

            }

            //Kolejka


            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Wojtek", Nazwisko = "Starak" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Jabola" });
            kolejka.Enqueue(new Pracownik { Imie = "Marysia", Nazwisko = "Pysia" });
            kolejka.Enqueue(new Pracownik { Imie = "Ula", Nazwisko = "Srula" });

            
            foreach (var kolejPracow in kolejka)
            {
                Console.WriteLine(kolejPracow.Imie + "  "+ kolejPracow.Nazwisko);   
            }

            while (kolejka.Count>0)
            {
                var pracownik =   kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " "+ pracownik.Nazwisko);
            }

        }
    }
}

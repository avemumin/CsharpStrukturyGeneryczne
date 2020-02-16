﻿using System;
using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>();
            Assert.IsTrue(kolejka.JestPusty);

        }

        [TestMethod]
        public void KolejkaTrzyElementowaPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.Zapisz(3.8);
            kolejka.Zapisz(5.7);
            kolejka.Zapisz(9.1);

            Assert.IsTrue(kolejka.JestPelny);
        }

        [TestMethod]
        public void SprawdzCzyFiFo()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);

            var wartosc1 = 4.6;
            var wartosc2 = 3.7;

            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());

            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void CzyElementySaPoprawnieNadpisaneGdyWiekszaNizPojemnosc()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var warosci = new[] { 1.2, 2.4, 3.6, 4.8, 5.3, 6.8 };
            foreach (var wartosc in warosci)
            {
                kolejka.Zapisz(wartosc);
            }
            
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(warosci[3],kolejka.Czytaj());
            Assert.AreEqual(warosci[4], kolejka.Czytaj());
            Assert.AreEqual(warosci[5], kolejka.Czytaj());

            Assert.IsTrue(kolejka.JestPusty);
        }
    }
}

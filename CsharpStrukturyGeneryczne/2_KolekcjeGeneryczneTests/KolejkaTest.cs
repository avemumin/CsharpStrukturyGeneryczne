using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class KolejkaTest
    {
        private Queue<int> kolejka;
        public KolejkaTest()
        {
            kolejka = new Queue<int>();
            ZasilKolejke();
        }

        private void ZasilKolejke()
        {
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
        }
        [TestMethod]
        public void UzycPeek()
        {
            Assert.AreEqual(1, kolejka.Peek());
        }

        [TestMethod]
        public void UzycieContains()
        {
            Assert.IsTrue(kolejka.Contains(3));
        }

        [TestMethod]
        public void ToArray()
        {
            var tablica = kolejka.ToArray();
            Assert.AreEqual(1,tablica[0]);
            kolejka.Dequeue();
            Assert.AreEqual(1, tablica[0]);
            Assert.AreEqual(3,kolejka.Count);
        }

        [TestMethod]
        public void UzycieClear()
        {
            kolejka.Clear();
            Assert.AreEqual(0,kolejka.Count);
        }
    }
}

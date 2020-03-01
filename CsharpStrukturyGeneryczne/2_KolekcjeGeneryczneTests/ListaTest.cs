using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Add(4);

            Assert.AreEqual(4, listaLiczb[3]);
        }
        [TestMethod]
        public void ListaMozemyDodawacNaOkreslonejPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Insert(2,5);

            Assert.AreEqual(5,listaLiczb[2]);
        }

        [TestMethod]
        public void ListaUsuwanieElementuZlisty()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.Remove(2);

            Assert.IsTrue(listaLiczb.SequenceEqual(new List<int>{1,3}),"Usunięto liczbe 2");
        }

        [TestMethod]
        public void ListaUsuwanieElementuZkonkretnejPozycji()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.RemoveAt(1);

            Assert.IsTrue(listaLiczb.SequenceEqual(new []{1,3}));
        }

        [TestMethod]
        public void ListaMozemyWyszukiwac()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };


            Assert.AreEqual(listaLiczb.IndexOf(3),2);
        }

        [TestMethod]
        public void ListaCzyZawiera()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };


            Assert.IsTrue(listaLiczb.Contains(3));
        }
        [TestMethod]
        public void ListaMozemyDodawacZakresLiczb()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };
            listaLiczb.AddRange(new List<int>{4,5,6});

            Assert.AreEqual(listaLiczb.IndexOf(4), 3);
        }
    }
}

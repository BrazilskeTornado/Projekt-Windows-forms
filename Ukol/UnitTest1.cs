using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ukol
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test na vypis hlasky postavy
            HerniPostava postava = new HerniPostava();
            string hlaska = postava.VratHlasku(); 
            Assert.IsFalse(string.IsNullOrEmpty(hlaska));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //test na delku jmena
            int max = 10;
            Form1 formular = new Form1();
            formular.nazev = "osoba";
            Assert.IsTrue(formular.nazev.Length < max);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //test na delku jmena
            int max = 10;
            Form1 formular = new Form1();
            formular.nazev = "ksksksksksksksksksksksksksk";
            Assert.IsTrue(formular.nazev.Length < max);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //test na zivoty bosse
            int zivotyBosse = 100;
            Assert.IsTrue(VratHP(zivotyBosse) > 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //test na zivoty bosse
            int zivotyBosse = 100;
            Assert.IsFalse(VratHP(zivotyBosse) > 0);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //test na zivoty osoby
            int zivotyOsoby = 100;
            Assert.IsTrue(VratHPOsoby(zivotyOsoby) > 0);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //test na zivoty osoby
            int zivotyOsoby = 100;
            Assert.IsFalse(VratHPOsoby(zivotyOsoby) > 0);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //test na damage bosse
            int damage = 20;
            Assert.IsTrue(Damage(damage) > 0);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //test na damage bosse
            int damage = 20;
            Assert.IsFalse(Damage(damage) > 0);
        }

        [TestMethod]
        public void TestMethod10()
        {
            // test na XP
            int xp = 1000;
            Assert.IsTrue(XP(xp) > 0);
        }

        [TestMethod]
        public void TestMethod11()
        {
            // test na XP
            int xp = 1000;
            Assert.IsFalse(XP(xp) > 0);
        }
    }
}

using testyJednostkowe;

namespace projektTestuJednostkowego
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodSuma()
        {
            Assert.AreEqual(11, kalkulator.suma(2, 10));
        }

        [TestMethod]
        public void TestMethodNWD()
        {
            Assert.AreEqual(10, kalkulator.nwd(10, 50));
        }

        [TestMethod]
        public void TestMethodCzyPierwsza1()
        {
            Assert.IsFalse(kalkulator.czyPierwsza(1));
        }

        [TestMethod]
        public void TestMethodCzyPierwszaPierwsza()
        {
            Assert.IsTrue(kalkulator.czyPierwsza(17));
        }

        [TestMethod]
        public void TestMethodKwadratLiczbyPierwszej()
        {
            Assert.IsFalse(kalkulator.czyPierwsza(225));
        }


    }
}

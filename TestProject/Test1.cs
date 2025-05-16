using TubesKPL;
using KonversiHarga;

namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestKonversiHargaMobil()
        {
            Assert.AreEqual(20000, Konversi.KonversiHarga(10000,"mobil"));
        }
        [TestMethod]
        public void TestKonversiHargaTruk()
        {
            Assert.AreEqual(30000, Konversi.KonversiHarga(10000,"truk"));
        }
        [TestMethod]
        public void TestKonversiHargaKereta()
        {
            Assert.AreEqual(100000, Konversi.KonversiHarga(10000,"kereta"));
        }
        [TestMethod]
        public void TestKonversiHargaPesawat()
        {
            Assert.AreEqual(100000, Konversi.KonversiHarga(10000,"pesawat"));
        }
        [TestMethod]
        public void TestProsesCuciSiram()
        {
            ACuciKendaraan aCuci = new ACuciKendaraan("Beat", "Motor");
            ProsesCuci proses = new ProsesCuci();
            Assert.AreEqual("Beat Sedang disiram", proses.ProsesInput(aCuci, "Siram"));
        }
        [TestMethod]
        public void TestProsesCuciSabun()
        {
            ACuciKendaraan aCuci = new ACuciKendaraan("Beat", "Motor");
            ProsesCuci proses = new ProsesCuci();
            Assert.AreEqual("Beat Sedang disabun", proses.ProsesInput(aCuci, "Sabun"));
        }
        [TestMethod]
        public void TestProsesCuciKeringkan()
        {
            ACuciKendaraan aCuci = new ACuciKendaraan("Beat", "Motor");
            ProsesCuci proses = new ProsesCuci();
            Assert.AreEqual("Kendaraan anda belum dicuci", proses.ProsesInput(aCuci, "Keringkan"));
        }
    }
}

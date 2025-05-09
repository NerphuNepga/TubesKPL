using System.Diagnostics;

namespace KonversiHarga
{
    public static class Konversi
    {
        public static double KonversiHarga(double jumlah, string jenisKendaraan)
        {
            double total = 0;
            if (jenisKendaraan == "mobil") { total = 2 * jumlah; }
            else if (jenisKendaraan == "truk") { total = 3 * jumlah; }
            else if (jenisKendaraan == "kereta" || jenisKendaraan == "pesawat") { total = 10 * jumlah; }
            else { total = jumlah; }
            return total;
        }
    }
}

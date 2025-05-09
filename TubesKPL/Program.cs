using KonversiHarga;
using System.Collections.Generic;
using System.Diagnostics;
using TubesKPL;

KendaraanConfig config = new KendaraanConfig();
CuciKendaraan cuci = new CuciKendaraan();
ProsesCuci proses = new ProsesCuci();

Console.WriteLine("================================");
Console.WriteLine("Selamat Datang di ACuciKendaraan");
Console.WriteLine("================================");

Console.Write("Masukkan Nama Kendaraan : ");
string namaK = Console.ReadLine();

Console.Write("Masukkan Jenis Kendaraan : ");
string jenisK = Console.ReadLine();

ACuciKendaraan aCuci = new ACuciKendaraan(namaK, jenisK);
config.UpdateConfig(aCuci);

cuci.Cuci(aCuci);
proses.kerjakan(aCuci);

double total = Konversi.KonversiHarga(proses.jumlah, jenisK.ToLower()); ;


ACuciKendaraan kci = config.ReadConfigFile();

Console.WriteLine();
Console.WriteLine("================================");
Console.WriteLine("Detail Pembayaran");
Console.WriteLine("================================");
Console.WriteLine("Nama kendaraan   : " + kci.namaKendaraan);
Console.WriteLine("Jenis kendaraan  : " + kci.jenisKendaraan);
Console.WriteLine("Total Harga      : Rp. " + total);

Console.WriteLine("Pilih metode pembayaran: Kartu Kredit, Transfer, Cash.");
string metodeBayar = Console.ReadLine();
try
{
    var metodePembayaran = PemilihanMetode.PilihMetode(metodeBayar, total);

    Type tipeBayar = typeof(MetodePembayaran<>).MakeGenericType(metodePembayaran.GetType());
    dynamic bayar = Activator.CreateInstance(tipeBayar, metodePembayaran);

    bayar.Bayar(total);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
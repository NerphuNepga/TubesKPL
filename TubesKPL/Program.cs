using KonversiHarga;
using MenuACuciKendaraan;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using TubesKPL;


KendaraanConfig config = new KendaraanConfig();
CuciKendaraan cuci = new CuciKendaraan();
ProsesCuci proses = new ProsesCuci();

string input = "1";
Menu.MainMenu();

string[] kendaraan = Menu.TambahKendaraan();
string namaK = kendaraan[0];
string jenisK = kendaraan[1];

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
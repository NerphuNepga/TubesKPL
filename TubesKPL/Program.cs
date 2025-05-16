using KonversiHarga;
using MenuACuciKendaraan;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using TubesKPL;


KendaraanConfig config = new KendaraanConfig();
CuciKendaraan cuci = new CuciKendaraan();
ProsesCuci proses = new ProsesCuci();
ACuciKendaraan aCuci = new ACuciKendaraan();
Menu.MainMenu();
Console.Write("Masukkan Perintah : ");
int input = int.Parse(Console.ReadLine());
while(input != 0)
{
    if (input == 1)
    {
        Console.Write("Masukkan Nama Kendaraan : ");
        string namaK = Console.ReadLine();

        Console.Write("Masukkan Jenis Kendaraan : ");
        string jenisK = Console.ReadLine();

        aCuci = new ACuciKendaraan(namaK, jenisK);
        config.UpdateConfig(aCuci);        
    }
    else if (input == 2) {
        cuci.Cuci(aCuci);
    }
    else if (input == 3)
    {
        proses.kerjakan(aCuci);
    }
    else
    {
        Console.WriteLine("Perintah tidak tersedia");
    }
    Menu.MainMenu();
    Console.Write("Masukkan Perintah : ");
    input = int.Parse(Console.ReadLine());
}
double total = Konversi.KonversiHarga(proses.jumlah, aCuci.getJenisKendaraan().ToLower()); ;

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
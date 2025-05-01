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

float total = 0;
if (jenisK.ToLower() == "mobil") { total = 2 * proses.jumlah; }
else if (jenisK.ToLower() == "truk") { total = 3 * proses.jumlah; }
else if (jenisK.ToLower() == "kereta" || jenisK.ToLower() == "pesawat") { total = 10 * proses.jumlah; }
else { total = proses.jumlah; }

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
IMetodePembayaran bayar = pemilihanMetode.PilihMetode(metodeBayar, total);
bayar.Bayar(total);
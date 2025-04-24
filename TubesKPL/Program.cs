using System.Collections.Generic;
using TubesKPL;
/*
CuciKendaraan cuci = new CuciKendaraan();
Console.WriteLine("================================");
Console.WriteLine("Selamat Datang di ACuciKendaraan");
Console.WriteLine("================================");
Console.Write("Masukkan Nama Kendaraan : ");
string namaK = Console.ReadLine();
Console.Write("Masukkan Jenis Kendaraan : ");
string jenisK = Console.ReadLine();
ACuciKendaraan aCuci = new ACuciKendaraan(namaK, jenisK);
cuci.Cuci(aCuci);
ProsesCuci proses = new ProsesCuci();
proses.kerjakan(aCuci);
*/

//config

KendaraanConfig config = new KendaraanConfig();
ACuciKendaraan kci = config.ReadConfigFile();
Console.WriteLine("Nama kendaraan: " + kci.namaKendaraan);
Console.WriteLine("Jenis kendaraan: " + kci.jenisKendaraan);

//tes generic
Console.WriteLine("Metode Pembayaran: Kartu Kredit, Transfer, Cash.");
string metodeBayar = Console.ReadLine();
float jumlah = 1000;
var bayar = pemilihanMetode.pilihMetode(metodeBayar, jumlah);
((dynamic)bayar).ProsesPembayaran(jumlah);
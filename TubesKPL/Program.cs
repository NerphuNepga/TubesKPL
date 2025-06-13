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
        Console.Write("Masukkan Nama Pemilik : ");
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
double total = Konversi.KonversiHarga(proses.jumlah, aCuci.GetJenisKendaraan().ToLower()); ;

ACuciKendaraan kci = config.ReadConfigFile();

Menu.MenuPembayaran(kci.namaPemilik, kci.jenisKendaraan, total);

Console.WriteLine("Pilih metode pembayaran: Kartu Kredit, Transfer, Cash.");
string metodeBayar = Console.ReadLine();
try
{
    switch (metodeBayar.ToLower())
    {
        case "kartu kredit":
            Console.Write("Masukan nomor kartu: ");
            string noKartu = Console.ReadLine();
            KartuKreditCreator kartuCreator = new KartuKreditCreator(noKartu);
            Console.WriteLine(kartuCreator.ProsesPembayaranUtama(total));
            break;

        case "transfer":
            Console.Write("Masukan nomor rekening: ");
            string noRekening = Console.ReadLine();
            TransferCreator transferCreator = new TransferCreator(noRekening);
            Console.WriteLine(transferCreator.ProsesPembayaranUtama(total));
            break;

        case "cash":
            Console.Write("Masukkan jumlah uang yang anda pakai: ");
            if (int.TryParse(Console.ReadLine(), out int tunai))
            {
                CashCreator cashCreator = new CashCreator(tunai);
                Console.WriteLine(cashCreator.ProsesPembayaranUtama(total));
            }
            else
            {
                throw new FormatException("Input jumlah uang tunai tidak valid.");
            }
            break;

        default:
            throw new ArgumentException("Metode pembayaran tidak didukung.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
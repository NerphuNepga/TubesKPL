namespace MenuACuciKendaraan
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Selamat Datang di ACuciKendaraan");
            Console.WriteLine("================================");
            Console.WriteLine("1. Tambah Kendaraan");
            Console.WriteLine("2. Lihat Antrian");
            Console.WriteLine("3. Cuci Kendaraan");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("================================");
        }

        public static string[] TambahKendaraan()
        {
            Console.Write("Masukkan Nama Kendaraan : ");
            string namaK = Console.ReadLine();

            Console.Write("Masukkan Jenis Kendaraan : ");
            string jenisK = Console.ReadLine();

            string[] hasil = { namaK, jenisK};
            return hasil;
        }
    }
}

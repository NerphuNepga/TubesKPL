namespace MenuACuciKendaraan
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Selamat Datang di ACuciKendaraan");
            Console.WriteLine("================================");
            Console.WriteLine("1. Masukkan Kendaraan");
            Console.WriteLine("2. Lihat Kendaraan");
            Console.WriteLine("3. Cuci Kendaraan");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("================================");
        }

        public static void MenuPembayaran(string namaPemilik, string jenisKendaraan, double total)
        {
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("Detail Pembayaran");
            Console.WriteLine("================================");
            Console.WriteLine("Nama Pemilik   : " + namaPemilik);
            Console.WriteLine("Jenis kendaraan  : " + jenisKendaraan);
            Console.WriteLine("Total Harga      : Rp. " + total);
        }
    }
}

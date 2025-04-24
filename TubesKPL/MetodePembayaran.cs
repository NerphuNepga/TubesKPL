using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    interface IMetodePembayaran
    {
        public void ProsesPembayaran(float jumlah);
    }

    public class KartuKredit : IMetodePembayaran
    {
        public string nomorKartu {  get; set; }

        public void ProsesPembayaran(float jumlah)
        {
            Console.WriteLine("Membayar dengan kartu kredit bernomor " + nomorKartu + " sejumlah Rp " + jumlah + ".");
        }
    }
    public class Transfer : IMetodePembayaran
    {
        public string nomorRekening {  get; set; }
        public void ProsesPembayaran(float jumlah)
        {
            Console.WriteLine("Membayar dengan cara transfer dengan nomor rekening " + nomorRekening + " sejumlah Rp " + jumlah + ".");
        }
    }
    public class Cash : IMetodePembayaran
    {
        public void ProsesPembayaran(float jumlah)
        {
            Console.WriteLine("Membayar dengan cash sejumlah Rp " + jumlah + ".");
        }
    }
    public static class pemilihanMetode
    {
        public static object pilihMetode(string metode,  float jumlah)
        {
            switch (metode)
            {
                case "Kartu Kredit":
                    Console.Write("Masukan nomor kartu: ");
                    string noKartu = Console.ReadLine();
                    return new KartuKredit { nomorKartu = noKartu };
                case "Transfer":
                    Console.Write("Masukan nomor rekening: ");
                    string noRekening = Console.ReadLine();
                    return new Transfer { nomorRekening = noRekening };
                case "Cash":
                    return new Cash();
                default:
                    throw new ArgumentException("Metode tidak dikenal.");
            }
        }
    }
    internal class MetodePembayaran<T> where T : IMetodePembayaran
    {
        public T metodeBayar {  get; set; }
        public float jumlah {  get; set; }
        
        public void Bayar()
        {
            metodeBayar.ProsesPembayaran(jumlah);
        }
    }
}

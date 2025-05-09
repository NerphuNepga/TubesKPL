using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public interface IPembayaran
    {
        public void ProsesPembayaran(double jumlah);
    }

    public class KartuKredit : IPembayaran
    {
        public string nomorKartu {  get; set; }

        public void ProsesPembayaran(double jumlah)
        {
            Debug.Assert(jumlah >= 0);
            Console.WriteLine("Membayar dengan kartu kredit bernomor " + nomorKartu + " sejumlah Rp " + jumlah + ".");
        }
    }
    public class Transfer : IPembayaran
    {
        public string nomorRekening {  get; set; }
        public void ProsesPembayaran(double jumlah)
        {
            Debug.Assert(jumlah >= 0);
            Console.WriteLine("Membayar dengan cara transfer dengan nomor rekening " + nomorRekening + " sejumlah Rp " + jumlah + ".");
        }
    }
    public class Cash : IPembayaran
    {
        public void ProsesPembayaran(double jumlah)
        {
            Debug.Assert(jumlah >= 0);
            Console.WriteLine("Membayar dengan cash sejumlah Rp " + jumlah + ".");
        }
    }
    public static class PemilihanMetode
    {
        public static IPembayaran PilihMetode(string metode,  double jumlah)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(metode));
            Debug.Assert(jumlah >= 0);
            switch (metode.ToLower())
            {
                case "kartu kredit":
                    Console.Write("Masukan nomor kartu: ");
                    string noKartu = Console.ReadLine();
                    KartuKredit kartuKredit = new KartuKredit { nomorKartu = noKartu };
                    return kartuKredit;
                case "transfer":
                    Console.Write("Masukan nomor rekening: ");
                    string noRekening = Console.ReadLine();
                    Transfer transfer = new Transfer { nomorRekening = noRekening };
                    return transfer;
                case "cash":
                    Cash cash = new Cash();
                    return cash;
                default:
                    throw new ArgumentException("Metode tidak dikenal.");
            }
        }
    }
    public class MetodePembayaran<T> where T : IPembayaran
    {
        private T metodeBayar {  get; set; }

        public MetodePembayaran(T metodeBayar)
        {
            this.metodeBayar = metodeBayar;
        }

        public void Bayar(double jumlah)
        {
            metodeBayar.ProsesPembayaran(jumlah);
        }
    }
}

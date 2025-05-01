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
        public void ProsesPembayaran(float jumlah);
    }

    public interface IMetodePembayaran
    {
        public void Bayar(float jumlah);
    }

    public class KartuKredit : IPembayaran
    {
        public string nomorKartu {  get; set; }

        public void ProsesPembayaran(float jumlah)
        {
            Debug.Assert(jumlah >= 0);
            Console.WriteLine("Membayar dengan kartu kredit bernomor " + nomorKartu + " sejumlah Rp " + jumlah + ".");
        }
    }
    public class Transfer : IPembayaran
    {
        public string nomorRekening {  get; set; }
        public void ProsesPembayaran(float jumlah)
        {
            Debug.Assert(jumlah >= 0);
            Console.WriteLine("Membayar dengan cara transfer dengan nomor rekening " + nomorRekening + " sejumlah Rp " + jumlah + ".");
        }
    }
    public class Cash : IPembayaran
    {
        public void ProsesPembayaran(float jumlah)
        {
            Debug.Assert(jumlah >= 0);
            Console.WriteLine("Membayar dengan cash sejumlah Rp " + jumlah + ".");
        }
    }
    public static class pemilihanMetode
    {
        public static IMetodePembayaran PilihMetode(string metode,  float jumlah)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(metode));
            Debug.Assert(jumlah >= 0);
            switch (metode)
            {
                case "Kartu Kredit":
                    Console.Write("Masukan nomor kartu: ");
                    string noKartu = Console.ReadLine();
                    KartuKredit kartuKredit = new KartuKredit { nomorKartu = noKartu };
                    return new MetodePembayaran<KartuKredit>
                    {
                        metodeBayar = kartuKredit
                    };
                case "Transfer":
                    Console.Write("Masukan nomor rekening: ");
                    string noRekening = Console.ReadLine();
                    Transfer transfer = new Transfer { nomorRekening = noRekening };
                    return new MetodePembayaran<Transfer>
                    {
                        metodeBayar = transfer
                    };
                case "Cash":
                    Cash cash = new Cash();
                    return new MetodePembayaran<Cash>
                    {
                        metodeBayar = cash
                    };
                default:
                    throw new ArgumentException("Metode tidak dikenal.");
            }
        }
    }
    public class MetodePembayaran<T> : IMetodePembayaran where T : IPembayaran
    {
        public T metodeBayar {  get; set; }
        
        public void Bayar(float jumlah)
        {
            metodeBayar.ProsesPembayaran(jumlah);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public interface IPembayaran<T>
    {
        string GetMetodeName();
        string ProsesPembayaran(double jumlah);
        T GetDetailPembayaran();
    }

    public class KartuKredit : IPembayaran<string>
    {
        private string nomorKartu;

        public KartuKredit(string nomorKartu)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(nomorKartu), "Nomor kartu tidak boleh kosong.");
            this.nomorKartu = nomorKartu;
        }

        public string GetMetodeName() { return "Kartu Kredit"; }
        public string GetDetailPembayaran() { return nomorKartu; }

        public string ProsesPembayaran(double jumlah)
        {
            Debug.Assert(jumlah >= 0, "Jumlah pembayaran tidak boleh negatif.");
            return $"Membayar dengan {GetMetodeName()} bernomor {nomorKartu} sejumlah Rp {jumlah}.";
        }
    }
    public class Transfer : IPembayaran<string>
    {
        private string nomorRekening;

        public Transfer(string nomorRekening)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(nomorRekening), "Nomor rekening tidak boleh kosong.");
            this.nomorRekening = nomorRekening;
        }

        public string GetMetodeName() { return "Transfer Bank"; }
        public string GetDetailPembayaran() { return nomorRekening; }

        public string ProsesPembayaran(double jumlah)
        {
            Debug.Assert(jumlah >= 0, "Jumlah pembayaran tidak boleh negatif.");
            return $"Membayar dengan {GetMetodeName()} dengan nomor rekening {nomorRekening} sejumlah Rp {jumlah}.";
        }
    }
    public class Cash : IPembayaran<int>
    {
        private int uangTunai;

        public Cash(int uangTunai)
        {
            Debug.Assert(uangTunai >= 0, "Jumlah uang tunai tidak boleh negatif.");
            this.uangTunai = uangTunai;
        }

        public string GetMetodeName() { return "Cash"; }
        public int GetDetailPembayaran() { return uangTunai; }

        public string ProsesPembayaran(double jumlah)
        {
            Debug.Assert(jumlah >= 0, "Jumlah pembayaran tidak boleh negatif.");
            Console.WriteLine($"Membayar dengan {GetMetodeName()} sejumlah Rp {jumlah} dengan jumlah uang Rp {uangTunai}.");
            double kembalian = uangTunai - jumlah;
            if (kembalian < 0)
            {
                return $"Uang tidak cukup. Kurang Rp {-kembalian}.";
            }
            else
            {
                return $"Kembalian Rp {kembalian}.";
            }
        }
    }

    public abstract class MetodePembayaranCreator<TDetail>
    {
        public abstract IPembayaran<TDetail> FactoryMethod();

        public string ProsesPembayaranUtama(double jumlah)
        {
            var pembayaran = FactoryMethod(); // Mendapatkan produk generik
            Console.WriteLine(pembayaran.ProsesPembayaran(jumlah)); // Memanggil operasi pada produk
            Console.WriteLine($"Detail pembayaran: {pembayaran.GetDetailPembayaran()}"); // Memanggil generic method pada produk

            return $"Creator: Transaksi selesai menggunakan metode {pembayaran.GetMetodeName()}.";
        }
    }

    public class KartuKreditCreator : MetodePembayaranCreator<string>
    {
        private string nomorKartu;

        public KartuKreditCreator(string nomorKartu)
        {
            this.nomorKartu = nomorKartu;
        }

        public override IPembayaran<string> FactoryMethod()
        {
            return new KartuKredit(nomorKartu);
        }
    }

    public class TransferCreator : MetodePembayaranCreator<string>
    {
        private string nomorRekening;

        public TransferCreator(string nomorRekening)
        {
            this.nomorRekening = nomorRekening;
        }

        public override IPembayaran<string> FactoryMethod()
        {
            return new Transfer(nomorRekening);
        }
    }

    public class CashCreator : MetodePembayaranCreator<int>
    {
        private int uangTunai;

        public CashCreator(int uangTunai)
        {
            this.uangTunai = uangTunai;
        }

        public override IPembayaran<int> FactoryMethod()
        {
            return new Cash(uangTunai);
        }
    }

}

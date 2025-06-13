using System;
using System.Diagnostics;

namespace TubesKPL
{
    public class CuciKendaraan
    {
        private readonly string[] jenis = { "Mobil", "Motor", "Truk", "Pesawat", "Kereta" };
        private readonly string[] tempat = { "Garasi", "Garasi", "Lapangan", "Hangar", "Stasiun" };

        public CuciKendaraan() { }

        public void Cuci(ACuciKendaraan aCuci)
        {
            //Precondition
            if (aCuci == null)
                throw new ArgumentNullException(nameof(aCuci), "Precondition failed: aCuci tidak boleh null.");
            if (string.IsNullOrWhiteSpace(aCuci.GetJenisKendaraan()))
                throw new ArgumentException("Precondition failed: Jenis kendaraan tidak boleh kosong.");
            if (string.IsNullOrWhiteSpace(aCuci.GetNamaPemilik()))
                throw new ArgumentException("Precondition failed: Nama pemilik tidak boleh kosong.");

            bool ditemukan = false;

            for (int i = 0; i < jenis.Length; i++)
            {
                if (aCuci.GetJenisKendaraan() == jenis[i])
                {
                    Console.WriteLine(aCuci.GetNamaPemilik() + " sedang antri di " + tempat[i]);
                    ditemukan = true;
                    break;
                }
            }

            //Postcondition
            Debug.Assert(ditemukan, "Postcondition failed: Jenis kendaraan tidak dikenali.");
        }
    }
}

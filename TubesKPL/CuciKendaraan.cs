using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    class CuciKendaraan
    {
        string[] jenis = {"Mobil","Motor","Truk","Pesawat","Kereta"};
        string[] tempat = {"Garasi","Garasi","Lapangan","Hangar","Stasiun"};
        public CuciKendaraan() { }
        public void Cuci(ACuciKendaraan aCuci)
        {
            for(int i = 0; i < jenis.Length; i++)
            {
                if (aCuci.getJenisKendaraan() == jenis[i])
                {
                    Console.WriteLine(aCuci.getNamaKendaraan() + " sedang antri di " + tempat[i]);
                }
            }
        }
    }
}

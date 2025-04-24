using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    class ACuciKendaraan
    {
        public string namaKendaraan;
        public string jenisKendaaraan;

        public ACuciKendaraan(string namaKendaraan, string jenisKendaaraan)
        {
            this.namaKendaraan = namaKendaraan;
            this.jenisKendaaraan = jenisKendaaraan;
        }
        public string getNamaKendaraan() {
            return this.namaKendaraan;
        }
        public string getJenisKendaraan() {
            return this.jenisKendaaraan;
        }
    }
}

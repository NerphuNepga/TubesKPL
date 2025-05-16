using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public class ACuciKendaraan
    {
        public string namaKendaraan { get; set; }
        public string jenisKendaraan { get; set; }
        public State state { get; set; }
        public ACuciKendaraan() { }
        public ACuciKendaraan(string namaKendaraan, string jenisKendaaraan)
        {
            this.namaKendaraan = namaKendaraan;
            this.jenisKendaraan = jenisKendaaraan;
            state = State.Masuk;
        }
        public string getNamaKendaraan() {
            return this.namaKendaraan;
        }
        public string getJenisKendaraan() {
            return this.jenisKendaraan;
        }
        public State GetState()
        {
            return this.state;
        }
        public void SetState(State state) {
            this.state = state;
        }
    }
}

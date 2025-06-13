using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public class ACuciKendaraan
    {
        public string namaPemilik { get; set; }
        public string jenisKendaraan { get; set; }
        public State state { get; set; }
        public ACuciKendaraan() { }
        public ACuciKendaraan(string namaPemilik, string jenisKendaaraan)
        {
            this.namaPemilik = namaPemilik;
            this.jenisKendaraan = jenisKendaaraan;
            state = State.Masuk;
        }
        public string GetNamaPemilik() {
            return this.namaPemilik;
        }
        public string GetJenisKendaraan() {
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

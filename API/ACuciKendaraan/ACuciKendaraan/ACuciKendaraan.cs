namespace ACuciKendaraan
{
    public class ACuciKendaraan
    {
        public string namaKendaraan { get; set; }
        public string jenisKendaraan { get; set; }
        public State nstate { get; set; }
        public ProsesCuci proses;
        public ACuciKendaraan() { }
        public ACuciKendaraan(string namaKendaraan, string jenisKendaaraan, State state)
        {
            this.namaKendaraan = namaKendaraan;
            this.jenisKendaraan = jenisKendaaraan;
            this.nstate = state;
            this.proses = new ProsesCuci();
        }
        public string getNamaKendaraan()
        {
            return this.namaKendaraan;
        }
        public string getJenisKendaraan()
        {
            return this.jenisKendaraan;
        }public State GetState()
        {
            return this.nstate;
        }
        public State SetState(ProsesCuci proses)
        {
            return nstate = proses.getState();
        }
        public string ProsesLangkah(string input)
        {
            string hasil = proses.kerjakan(this, input);
            this.nstate = proses.getState();
            return hasil;
        }
    }
}

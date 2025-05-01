namespace ACuciKendaraan
{
    public class ACuciKendaraan
    {
        public string namaKendaraan { get; set; }
        public string jenisKendaraan { get; set; }

        public ACuciKendaraan() { }
        public ACuciKendaraan(string namaKendaraan, string jenisKendaaraan)
        {
            this.namaKendaraan = namaKendaraan;
            this.jenisKendaraan = jenisKendaaraan;
        }
        public string getNamaKendaraan()
        {
            return this.namaKendaraan;
        }
        public string getJenisKendaraan()
        {
            return this.jenisKendaraan;
        }

    }
}

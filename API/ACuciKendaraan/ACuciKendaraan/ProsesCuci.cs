namespace ACuciKendaraan
{
    public enum State { Masuk, Siram, Sabun, Keringkan }
    public class ProsesCuci
    {
        public float jumlah = 0;
        public State state;
        public ProsesCuci()
        {
            state = State.Masuk;
        }
        public void Siram()
        {
            state = State.Siram;
        }
        public void Sabun()
        {
            state = State.Sabun;
        }
        public void Keringkan()
        {
            state = State.Keringkan;
        }
        public State getState()
        {
            return state;
        }


        public string kerjakan(ACuciKendaraan aCuci, string input)
        {
            if (getState() == State.Masuk)
            {
                if (input == "Siram")
                {
                    Siram();
                    jumlah += 5000;
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang disiram";
                }
                else if (input == "Sabun")
                {
                    Sabun();
                    jumlah += 5000;
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang disabun";
                }
                else if (input == "Keringkan")
                {
                    return "Kendaraan anda belum dicuci";
                }
                else
                {
                    return "Perintah tidak tersedia";
                }
            }
            else if (getState() == State.Siram)
            {
                if (input == "Sabun")
                {
                    Sabun();
                    jumlah += 5000;
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang disabun";
                }
                else if (input == "Keringkan")
                {
                    Keringkan();
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang dikeringkan";
                }
                else if (input == "Siram")
                {
                    jumlah += 5000;
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang disiram lagi";
                }
                else
                {
                    return "Perintah tidak tersedia";
                }
            }
            else if (getState() == State.Sabun)
            {
                if (input == "Siram")
                {
                    Siram();
                    jumlah += 5000;
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang disiram";
                }
                else if (input == "Keringkan")
                {
                    Keringkan();
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang dikeringkan";
                }
                else if (input == "Sabun")
                {
                    jumlah += 5000;
                    return string.Format(aCuci.getNamaKendaraan()) + " Sedang ditambahi sabun";
                }
                else
                {
                    return "Perintah tidak tersedia";
                }
            }
            else if(getState() == State.Keringkan && input == "Selesai")
            {
                return string.Format(aCuci.getNamaKendaraan()) + " Sudah siap diambil. Jumlah yang harus dibayar : " + jumlah;
            }
                return null;
        }
    }
}


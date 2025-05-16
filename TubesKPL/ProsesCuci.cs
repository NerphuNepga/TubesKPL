using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public enum State { Masuk, Siram, Sabun, Keringkan }
    public class ProsesCuci
    {
        public double jumlah = 0;
        State state;
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

        public void kerjakan(ACuciKendaraan aCuci)
        {
            if (aCuci == null)
                throw new ArgumentNullException(nameof(aCuci), "Precondition failed: aCuci tidak boleh null.");

            Console.WriteLine("Kendaraan anda saat ini sudah " + getState());
            Console.WriteLine("List perintah : Siram, Sabun, Keringkan");

            while (state != State.Keringkan)
            {
                Console.Write("Manage Kendaraan Anda : ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input tidak boleh kosong.");
                    continue;
                }

                Console.WriteLine(ProsesInput(aCuci, input));
            }

            Console.WriteLine();
            Console.WriteLine(aCuci.getNamaKendaraan() + " Sudah siap diambil");
        }

        public string kerjakanAPI(ACuciKendaraan aCuci, string input)
        {
            // Preconditions
            if (aCuci == null)
                throw new ArgumentNullException(nameof(aCuci), "Precondition failed: aCuci tidak boleh null.");
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Precondition failed: input tidak boleh kosong.", nameof(input));

            string result = ProsesInput(aCuci, input);

            // Postcondition
            Debug.Assert(!string.IsNullOrWhiteSpace(result), "Postcondition failed: hasil proses tidak boleh kosong.");

            return result;
        }

        public string ProsesInput(ACuciKendaraan aCuci, string input)
        {
            switch (state)
            {
                case State.Masuk:
                    if (input == "Siram")
                    {
                        Siram();
                        aCuci.SetState(state);
                        jumlah += 5000;
                        return aCuci.getNamaKendaraan() + " Sedang disiram";
                    }
                    else if (input == "Sabun")
                    {
                        Sabun();
                        aCuci.SetState(state);
                        jumlah += 5000;
                        return aCuci.getNamaKendaraan() + " Sedang disabun";
                    }
                    else if (input == "Keringkan")
                    {
                        return "Kendaraan anda belum dicuci";
                    }
                    break;

                case State.Siram:
                    if (input == "Sabun")
                    {
                        Sabun();
                        aCuci.SetState(state);
                        jumlah += 5000;
                        return aCuci.getNamaKendaraan() + " Sedang disabun";
                    }
                    else if (input == "Keringkan")
                    {
                        Keringkan();
                        aCuci.SetState(state);
                        return aCuci.getNamaKendaraan() + " Sedang dikeringkan";
                    }
                    else if (input == "Siram")
                    {
                        jumlah += 5000;
                        return aCuci.getNamaKendaraan() + " Sedang disiram lagi";
                    }
                    break;

                case State.Sabun:
                    if (input == "Siram")
                    {
                        Siram();
                        aCuci.SetState(state);
                        jumlah += 5000;
                        return aCuci.getNamaKendaraan() + " Sedang disiram";
                    }
                    else if (input == "Keringkan")
                    {
                        Keringkan();
                        aCuci.SetState(state);
                        return aCuci.getNamaKendaraan() + " Sedang dikeringkan";
                    }
                    else if (input == "Sabun")
                    {
                        jumlah += 5000;
                        return aCuci.getNamaKendaraan() + " Sedang ditambahi sabun";
                    }
                    break;
            }

            return "Perintah tidak tersedia";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public enum State { Masuk, Cuci, Service, Keluar }
    public class ProsesCuci
    {
        public double jumlah = 0;
        State state;
        public ProsesCuci()
        {
            state = State.Masuk;
        }
        public void Cuci()
        {
            state = State.Cuci;
        }
        public void Service()
        {
            state = State.Service;
        }
        public void Keluar()
        {
            state = State.Keluar;
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
            Console.WriteLine("List perintah : Cuci, Service, Keluar");

            while (state != State.Keluar)
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
            Console.WriteLine(aCuci.GetJenisKendaraan() + " Sudah siap diambil");
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
                    if (input == "Cuci")
                    {
                        Cuci();
                        aCuci.SetState(state);

                        jumlah += 15000;
                        return aCuci.GetJenisKendaraan() + " Sedang dicuci";
                    }
                    else if (input == "Service")
                    {
                        Service();
                        aCuci.SetState(state);
                        jumlah += 50000;
                        return aCuci.GetJenisKendaraan() + " Sedang diservice";
                    }
                    else if (input == "Keluar")
                    {
                        return "Kendaraan anda belum dicuci";
                    }
                    break;

                case State.Cuci:
                    if (input == "Service")
                    {
                        Service();
                        aCuci.SetState(state);
                        jumlah += 50000;
                        return aCuci.GetJenisKendaraan() + " Sedang diservice";
                    }
                    else if (input == "Keluar")
                    {
                        Keluar();
                        aCuci.SetState(state);
                        return aCuci.GetJenisKendaraan() + " Sedang dikeluar";
                    }
                    else if (input == "Cuci")
                    {
                        jumlah += 15000;
                        return aCuci.GetJenisKendaraan() + " Sedang dicuci lagi";
                    }
                    break;

                case State.Service:
                    if (input == "Cuci")
                    {
                        Cuci();
                        aCuci.SetState(state);
                        jumlah += 15000;
                        return aCuci.GetJenisKendaraan() + " Sedang dicuci";
                    }
                    else if (input == "Keluar")
                    {
                        Keluar();
                        aCuci.SetState(state);
                        return aCuci.GetJenisKendaraan() + " Sedang dikeluar";
                    }
                    else if (input == "Service")
                    {
                        jumlah += 50000;
                        return aCuci.GetJenisKendaraan() + " Sedang ditambahi service";
                    }
                    break;
            }

            return "Perintah tidak tersedia";
        }
    }
}

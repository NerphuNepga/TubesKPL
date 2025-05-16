using System;
using System.Collections.Generic;
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
            Console.WriteLine("Kendaraan anda saat ini sudah " + getState());
            Console.WriteLine("List perintah : Siram, Sabun, Keringkan");
            while (state != State.Keringkan)
            {
                Console.Write("Manage Kendaraan Anda : ");
                string input = Console.ReadLine();
                if (getState() == State.Masuk)
                {
                    if (input == "Siram")
                    {
                        Siram();
                        aCuci.SetState(getState());
                        jumlah += 5000;
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang disiram");
                    }
                    else if (input == "Sabun")
                    {
                        Sabun();
                        aCuci.SetState(getState());
                        jumlah += 5000;
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang disabun");
                    }
                    else if (input == "Keringkan")
                    {
                        Console.WriteLine("Kendaraan anda belum dicuci");
                    }
                    else
                    {
                        Console.WriteLine("Perintah tidak tersedia");
                    }
                }
                else if (getState() == State.Siram)
                {
                    if (input == "Sabun")
                    {
                        Sabun();
                        aCuci.SetState(getState());
                        jumlah += 5000;
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang disabun");
                    }
                    else if (input == "Keringkan")
                    {
                        Keringkan();
                        aCuci.SetState(getState());
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang dikeringkan");
                    }
                    else if (input == "Siram")
                    {
                        jumlah += 5000;
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang disiram lagi");
                    }
                    else
                    {
                        Console.WriteLine("Perintah tidak tersedia");
                    }
                }
                else if (getState() == State.Sabun)
                {
                    if (input == "Siram")
                    {
                        Siram();
                        aCuci.SetState(getState());
                        jumlah += 5000;
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang disiram");
                    }
                    else if (input == "Keringkan")
                    {
                        Keringkan();
                        aCuci.SetState(getState());
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang dikeringkan");
                    }
                    else if (input == "Sabun")
                    {
                        jumlah += 5000;
                        Console.WriteLine(aCuci.getNamaKendaraan() + " Sedang ditambahi sabun");
                    }
                    else
                    {
                        Console.WriteLine("Perintah tidak tersedia");
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine(aCuci.getNamaKendaraan() + " Sudah siap diambil");
        }
        public string kerjakanAPI(ACuciKendaraan aCuci, string input)
        {
            if (getState() == State.Masuk)
            {
                if (input == "Siram")
                {
                    Siram();
                    aCuci.SetState(getState());
                    jumlah += 5000;
                    return aCuci.getNamaKendaraan() + " Sedang disiram";
                }
                else if (input == "Sabun")
                {
                    Sabun();
                    aCuci.SetState(getState());
                    jumlah += 5000;
                    return aCuci.getNamaKendaraan() + " Sedang disabun";       }
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
                    aCuci.SetState(getState());
                    jumlah += 5000;
                    return aCuci.getNamaKendaraan() + " Sedang disabun";
                }
                else if (input == "Keringkan")
                {
                    Keringkan();
                    aCuci.SetState(getState());
                    return aCuci.getNamaKendaraan() + " Sedang dikeringkan";
                }
                else if (input == "Siram")
                {
                    jumlah += 5000;
                    return aCuci.getNamaKendaraan() + " Sedang disiram lagi";
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
                    aCuci.SetState(getState());
                    jumlah += 5000;
                    return aCuci.getNamaKendaraan() + " Sedang disiram";
                }
                else if (input == "Keringkan")
                {
                    Keringkan();
                    aCuci.SetState(getState());
                    return aCuci.getNamaKendaraan() + " Sedang dikeringkan";
                }
                else if (input == "Sabun")
                {
                    jumlah += 5000;
                    return aCuci.getNamaKendaraan() + " Sedang ditambahi sabun";
                }
                else
                {
                    return "Perintah tidak tersedia";
                }
            }
            return "[500] Command Tidak Tersedia";
        }
    }
}

using System;

namespace kalkulator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator sederhana";

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine();

            Console.WriteLine("1. Perkalian");
            Console.WriteLine("2. Pembagian");
            Console.WriteLine("3. Pertambahan");
            Console.WriteLine("4. Pengurangan");

            Console.WriteLine();

            Console.Write("Masukan menu pilihan [1..4] : ");
            int pilihan = int.Parse(Console.ReadLine());
            if (pilihan <= 4)
            {
                Console.WriteLine();

                Console.Write("Masukan nilai A  : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Masukan nilai B  : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b)); // cara kedua
                        break;
                    case 2:
                        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b)); // cara kedua
                        break;
                    case 3:
                        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b)); // cara pertama 
                        break;
                    case 4:
                        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b)); // cara kedua
                        break;

                }
            }
            else Console.Write("Maaf kode menu yang anda masukkan tidak ada");


            Console.Write("\nTekan apa aja kalo mau keluar dari program");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(int a, int b)
        {
            return (float)a / b;
        }



    }
}


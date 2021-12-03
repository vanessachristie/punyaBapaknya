using System;
using System.Linq;

namespace ConsoleApp2
{

    class Program
    {
    public static void ulang(string again, int status, int array)
        {
            while (again != "y" && again != "n")
            {
                Console.Write("Ulangi? (y/n) ");
                again = Console.ReadLine();
            }
            if (again == "y")
            {
                Console.Write("Mau berapa angka? ");
                array = Convert.ToInt32(Console.ReadLine());
                again = "";
            }
            else if (again == "n")
            {
                status= 1;
            }
        }


        static void Main(string[] args)
        {
            int jumlahAngka = 0;
            Console.Write("Mau berapa angka? ");
            jumlahAngka = Convert.ToInt32(Console.ReadLine());
            int array = jumlahAngka;
            int[] koleksiAngka = new int[10000];
            int statusProgram = 0;
            int status = statusProgram;
            string mintaAgain = "";
            string again = mintaAgain;
            int hitungAngkaSama = 0;
            while (statusProgram == 0)
            {

                hitungAngkaSama = 0;
                for (int i = 0; i < 10000; i++)
                    koleksiAngka[i] = 0;


                for (int i = 0; i < jumlahAngka; i++)
                {
                    Console.Write("Masukkan angka ke - {0} : ", i + 1);
                    koleksiAngka[i] = Convert.ToInt32(Console.ReadLine());
                }

                var hasilGroup = koleksiAngka.GroupBy(v => v);
                foreach (var group in hasilGroup)
                {
                    if (group.Count() > 1 && group.Key != 0)
                    {
                        hitungAngkaSama++;
                        if (hitungAngkaSama == 1)
                        {
                            Console.WriteLine(">= Ada Angka Yang sama");
                        }
                        Console.WriteLine("{0} berjumlah {1}", group.Key, group.Count());
                    }

                }
                if (hitungAngkaSama == 0)
                {
                    Console.WriteLine("=> Tidak Ada angka yang sama");
                }

                while (mintaAgain != "y" && mintaAgain != "n")
                {
                    Console.Write("Ulangi? (y/n) ");
                    mintaAgain = Console.ReadLine();
                }
                if (mintaAgain == "y")
                {
                    Console.Write("Mau berapa angka? ");
                    jumlahAngka = Convert.ToInt32(Console.ReadLine());
                    mintaAgain = "";
                }
                else if (mintaAgain == "n")
                {
                    statusProgram = 1;
                }


            }

        }
    }
}

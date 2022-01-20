using System;

namespace little_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //CowokTinggi cowokTinggi = new CowokTinggi() { Nama = "Shelby", Tinggi = 78 };
            //CowokTinggi cowokTinggi = new CowokTinggi("Deddy", 78);
            //CowokTinggi badut = new CowokTinggi("Morgan", 77);
            //CowokTinggi badut = new CowokTinggi("Morgan", 77);
            //IBadut budi = badut;
            IBadut anto = new CowokTinggi("Antoho", 88);

            //cowokTinggi.CeritakanDiriAnda();
            //badut.CeritakanDiriAnda();
            // budi.CeritakanDiriAnda(); <-- INVALID
            CowokTinggi badu = (CowokTinggi)anto;

            badu.CeritakanDiriAnda();

            //Console.WriteLine($"Cowok tinggi ini punya {budi.HalLucu}");
            //budi.Bunyi();

            Console.WriteLine($"Cowok tinggi ini punya {badu.HalLucu}");
            badu.Bunyi();
        }
    }
}

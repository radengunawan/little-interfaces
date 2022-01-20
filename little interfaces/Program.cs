using System;

namespace little_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CowokTinggi cowokTinggi = new CowokTinggi() { Nama = "Shelby", Tinggi = 78 };


            cowokTinggi.CeritakanDiriAnda();

            Console.WriteLine($"Cowok tinggi ini punya {cowokTinggi.HalLucu}");
            cowokTinggi.Bunyi();
        }
    }
}

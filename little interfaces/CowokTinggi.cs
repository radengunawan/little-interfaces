using System;
using System.Collections.Generic;
using System.Text;

namespace little_interfaces
{
    class CowokTinggi : IBadut
    {
        public int Tinggi;
        public string Nama;

        //constructor custom
        public CowokTinggi (string Name, int tall)
        {
            this.Nama = Name;
            this.Tinggi = tall;
        }

        public void CeritakanDiriAnda()
        {
            Console.WriteLine($"My name are {this.Nama}, my height is {this.Tinggi} inches");
        } //end CeritakanDiriAnda

        public string HalLucu
        {
            get { return "motor gedes"; }
        } //end HalLucu


        public void Bunyi()
        {
            Console.WriteLine("Dang ding dung");
        }

    } //end class
}

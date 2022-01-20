using System;
using System.Collections.Generic;
using System.Text;

namespace little_interfaces
{
    class CowokTinggi
    {
        public int Tinggi;
        public string Nama;

        public void CeritakanDiriAnda()
        {
            Console.WriteLine($"My name are {this.Nama}, my height is {this.Tinggi} inches");
        }
    }
}

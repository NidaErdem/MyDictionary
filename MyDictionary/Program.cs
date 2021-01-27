using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();

            Ogrenci.Add(2035, "Nida Erdem");
            Ogrenci.Add(628, "Kaan Bakır");
            Ogrenci.Add(1062, "İpek Dolu");
            Ogrenci.Add(235, "Kübra Yurdagül");
            Ogrenci.Add(1682, "Hakan Yılmaz");

            Console.WriteLine(Ogrenci.Count);
        }
    }
}

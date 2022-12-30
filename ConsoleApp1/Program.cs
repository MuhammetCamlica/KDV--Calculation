
using System;

namespace gectkaldi;

class Program
{
    static void Main(string[] args)
    {

       Console.WriteLine("FİYAT GİRİNİZ..");
        var girilenfiyat = Console.ReadLine();

        var sonuc = (girilenfiyat  (18/ 100));

        Console.WriteLine("KDVLİ FİYAT : " + sonuc);

    }

}
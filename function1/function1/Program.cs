using System;

namespace function1
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine(ToplamaYap(5,9));
            int sayiKare = 2;
            Console.WriteLine(KareAl(sayiKare));
            Console.WriteLine(KupAl(ref sayiKare));
            
            Console.ReadLine();
        }

        static int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int KareAl(int sayi)
        {
            return sayi * sayi;
        }

        static int KupAl(ref int sayi)
        {
            return sayi * sayi * sayi;
        }
        //ref
        int sayi = 5;
        int sayi2 = 9;
        string metin = "ahmet mehmet";
    }
}
using System;

namespace function3
{
    class Program
    {
        static void Main(string[] args)
        {
            // //metin içinde kaç kelime var bul
            // Console.WriteLine("Bir cümle giriniz:");
            // string metin = Console.ReadLine();
            // int kelimeSayisi = KelimeSayisiBul(metin);
            // Console.WriteLine("cümledeki kelime sayısı:{0}",kelimeSayisi);
            
            //params
            int toplam2 =Topla(3, 4, 6, 3,5);
            Console.WriteLine(toplam2);
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(params int[] sayi)
        {
            int toplam = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                toplam += sayi[i];
            }

            return toplam;
        }
        private static int KelimeSayisiBul(string metin)
        {
            int sayac=1;
            //boşlukları say her boşlukta sayacı arttır.
            foreach (char karakter in metin)
            {
                if (karakter==' ')
                {
                    sayac++;
                }
            }
            return sayac;
        }
    }
}
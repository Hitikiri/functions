using System;

namespace function2
{
    class Program
    {
        static void Main(string[] args)
        {
            // //2 sayıyı kullanıcıdan alıp toplayan fonksiyonu yazın
            // int sayi1, sayi2;
            // int toplam;
            // Console.WriteLine("Sayı 1:");
            // sayi1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Sayı 2:");
            // sayi2 = Convert.ToInt32(Console.ReadLine());
            // toplam = Topla(sayi1, sayi2);
            // Console.WriteLine(toplam);
            //verilen ölçülerdeki karenin alanını hesaplayan fonksiyonu yazın.
            
            // Console.WriteLine("Karenin bir kenarını yazın:");
            // int kenar = Convert.ToInt32(Console.ReadLine());
            // int alan = KareAlaniHesapla(kenar);
            // Console.WriteLine("Karenin Alanı:" +alan);
            
            //Kare,Üçgen ve Daire seçilecek alan hesabı yapılacak
            Console.WriteLine("Alan hesaplamak istediğiniz şekili seçin:1-Kare 2-Üçgen 3-Daire");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Karenin kenarını girin:");
                    int a=Convert.ToInt32(Console.ReadLine());
                    int alan = KareAlaniHesapla(a);
                    Console.WriteLine("Karenin alani {0}dır",alan);
                    break;
                case 2:
                    Console.WriteLine("Tabanı girin");
                    int taban=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yüksekliği girin");
                    int h = Convert.ToInt32(Console.ReadLine());
                    int alan2 = ucgenAlan(taban, h);
                    Console.WriteLine("Ucgenin alanı:{0}",alan2);
                    
                    break;
                case 3:
                    Console.WriteLine("yarıçapı girin");
                    int yaricap = Convert.ToInt32(Console.ReadLine());
                    double alan3 = daireAlan(yaricap);
                    Console.WriteLine("Dairenin alanı:{0} ",alan3);
                    break;
                default:
                    Console.WriteLine("doğru bir işlem seçiniz");
                    break;
                    
            }


        }

        static double daireAlan(int yaricap)
        {
            return yaricap * yaricap * Math.PI;
        }

        static int ucgenAlan(int taban, int h)
        {
            return taban * h / 2;
        }

        static int KareAlaniHesapla(int aKenari)
        {
            return aKenari * aKenari;
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi2 + sayi1;
        }
    }
}
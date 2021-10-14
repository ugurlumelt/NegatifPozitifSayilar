using System;

namespace NegatifPozitifSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekrarYap = "q";
            while (tekrarYap=="q")
            {
                Console.WriteLine("Lütfen 10 adet sayı giriniz.");
                int pozitifSayi = 0;
                int negatifSayi = 0;
                int sifirSayisi = 0;

                int[] sayilar = new int[10];

                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.WriteLine("{0} . Sayıyı giriniz :", i + 1);
                    sayilar[i] = int.Parse(Console.ReadLine());
                }

                foreach (var sayi in sayilar)
                {
                    if (sayi > 0)
                    {
                        pozitifSayi++;
                    }
                    else if (sayi < 0)
                    {
                        negatifSayi++;
                    }
                    else
                    {
                        sifirSayisi++;
                    }
                }
                Console.WriteLine($"Pozitif sayı miktarı : {pozitifSayi}," +
                    $" Negatif sayı miktarı : {negatifSayi}," +
                    $"Sıfır sayı miktarı: { sifirSayisi}");
              
                Console.WriteLine("Tekrar yapmak için q'ya basınız !! ");
                Console.ReadLine();
            }
        }
    }
}

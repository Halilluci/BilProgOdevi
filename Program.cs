using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖdevProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Kaç öğrenci kaydetmek istiyorsunuz: ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());

            
            int[] numaralar = new int[ogrenciSayisi];
            string[] adlar = new string[ogrenciSayisi];
            string[] soyadlar = new string[ogrenciSayisi];
            int[] vizeNotlari = new int[ogrenciSayisi];
            int[] finalNotlari = new int[ogrenciSayisi];
            int[] ortalamalar = new int[ogrenciSayisi];
            string[] harfNotlari = new string[ogrenciSayisi];

            
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"{i + 1}. Öğrencinin bilgilerini giriniz:");

                
                Console.Write("Numarası: ");
                numaralar[i] = int.Parse(Console.ReadLine());

               
                Console.Write("Adı: ");
                adlar[i] = Console.ReadLine();

                
                Console.Write("Soyadı: ");
                soyadlar[i] = Console.ReadLine();

                
                while (true)
                {
                    Console.Write("Vize notu (0-100): ");
                    vizeNotlari[i] = int.Parse(Console.ReadLine());
                    if (vizeNotlari[i] >= 0 && vizeNotlari[i] <= 100) break;
                    Console.WriteLine("Geçersiz not, 0-100 arasında giriniz.");
                }

               
                while (true)
                {
                    Console.Write("Final notu (0-100): ");
                    finalNotlari[i] = int.Parse(Console.ReadLine());
                    if (finalNotlari[i] >= 0 && finalNotlari[i] <= 100) break;
                    Console.WriteLine("Geçersiz not, 0-100 arasında giriniz.");
                }

               
                ortalamalar[i] = (vizeNotlari[i] * 40 + finalNotlari[i] * 60) / 100;

                
                if (ortalamalar[i] >= 85)
                    harfNotlari[i] = "AA";
                else if (ortalamalar[i] >= 75)
                    harfNotlari[i] = "BA";
                else if (ortalamalar[i] >= 60)
                    harfNotlari[i] = "BB";
                else if (ortalamalar[i] >= 50)
                    harfNotlari[i] = "CB";
                else if (ortalamalar[i] >= 40)
                    harfNotlari[i] = "CC";
                else if (ortalamalar[i] >= 30)
                    harfNotlari[i] = "DC";
                else if (ortalamalar[i] >= 20)
                    harfNotlari[i] = "DD";
                else if (ortalamalar[i] >= 10)
                    harfNotlari[i] = "FD";
                else
                    harfNotlari[i] = "FF";
            }

            
            Console.WriteLine("\nNumara\tAd\tSoyad\tVize\tFinal\tOrtalama\tHarf Notu");
            int toplamOrtalama = 0;
            int enYuksek = ortalamalar[0];
            int enDusuk = ortalamalar[0];

            
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                toplamOrtalama += ortalamalar[i];
                if (ortalamalar[i] > enYuksek) enYuksek = ortalamalar[i];
                if (ortalamalar[i] < enDusuk) enDusuk = ortalamalar[i];

                Console.WriteLine($"{numaralar[i]}\t{adlar[i]}\t{soyadlar[i]}\t{vizeNotlari[i]}" + $"\t{finalNotlari[i]}\t{ortalamalar[i]}\t{harfNotlari[i]}");
            }

            
            Console.WriteLine($"\nSınıf Ortalaması: {toplamOrtalama / ogrenciSayisi}");
            Console.WriteLine($"En düşük not: {enDusuk}");
            Console.WriteLine($"En yüksek not: {enYuksek}");
            Console.ReadKey();
        }
    }
}


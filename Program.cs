using System.Transactions;

namespace ConsoleAppOdev
{
    internal class Program
    {
        
       static void Main(string[] args)
            {
                int ogrenci;

                
                Console.Write("Kaç öğrenci kaydetmek istiyorsunuz?: ");
                ogrenci = int.Parse(Console.ReadLine());

                
                int[] numara = new int[ogrenci];
                string[] ad = new string[ogrenci];
                string[] soyad = new string[ogrenci];
                int[] vize = new int[ogrenci];
                int[] final = new int[ogrenci];
                double[] ortalama = new double[ogrenci];
                string[] harfnotu= new string[ogrenci];

                
                for (int i = 0; i < ogrenci; i++)
                {
                    Console.WriteLine($"Öğrenci {i + 1}:");

                    
                    Console.Write("Öğrencinin Numarasını giriniz: ");
                    numara [i] = int.Parse(Console.ReadLine());

                    Console.Write("Öğrencinin Adını giriniz: ");
                    ad[i] = Console.ReadLine();

                    Console.Write("Öğrencinin Soyadını giriniz: ");
                    soyad[i] = Console.ReadLine();

                    
                    int not;
                    do
                    {
                        Console.Write("Vize notunu giriniz (0-100 arası): ");
                        not = int.Parse(Console.ReadLine());
                        if (not < 0 || not > 100)
                            Console.WriteLine("Geçersiz not! Lütfen 0-100 arası bir değer giriniz.");
                    } while (not < 0 || not > 100);
                    vize[i] = not;

                    
                    do
                    {
                        Console.Write("Final notunu giriniz (0-100 arası): ");
                        not = int.Parse(Console.ReadLine());
                        if (not < 0 || not> 100)
                            Console.WriteLine("Geçersiz not! Lütfen 0-100 arası bir değer giriniz.");
                    } while (not < 0 || not > 100);
                    final[i] = not;

                    
                    ortalama[i] = (vize[i] * 0.4) + (final[i] * 0.6);

                    
                    if (ortalama[i] >= 85) harfnotu[i] = "AA";
                    else if (ortalama[i] >= 75) harfnotu[i] = "BA";
                    else if (ortalama[i] >= 65) harfnotu[i] = "BB";
                    else if (ortalama[i] >= 50) harfnotu[i] = "CB";
                    else if (ortalama[i] >= 40) harfnotu[i] = "CC";
                    else if (ortalama[i] >= 30) harfnotu[i] = "DC";
                    else if (ortalama[i] >= 20) harfnotu[i] = "DD";
                    else if (ortalama[i] >= 10) harfnotu[i] = "FD";
                    else harfnotu   [i] = "FF";
                }

                
                Console.WriteLine("\nÖğrenci Bilgileri:");
                Console.WriteLine("Numara\tAd\tSoyad\tVize\tFinal\tOrtalama\tHarf Notu");

                double sınıfOrtalaması = 0;
                int minNot = 100, maxNot = 0;

                for (int i = 0; i < ogrenci; i++)
                {
                    Console.WriteLine($"{numara[i]}\t{ad[i]}\t{soyad[i]}\t{vize[i]}\t{final[i]}\t{ortalama[i]:0.00}\t{harfnotu[i]}");

                   
                    sınıfOrtalaması += ortalama[i];
                    if (ortalama[i] < minNot) minNot = (int)ortalama[i];
                    if (ortalama[i] > maxNot) maxNot = (int)ortalama[i];
                }

                sınıfOrtalaması /= ogrenci;

                
                Console.WriteLine($"\nSınıf Ortalaması: {sınıfOrtalaması:0.00}");
                Console.WriteLine($"En düşük not: {minNot}");
                Console.WriteLine($"En yüksek not: {maxNot}");
       }
        

    }
}   


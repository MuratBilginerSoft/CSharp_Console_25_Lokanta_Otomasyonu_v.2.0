using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Lokanta_Otomasyonu_v2._0
{
    class Program
    {
        public static string[] Menu = new string[] { "Kuru Fasulye", "Çiğ Köfte", "Çorba", "Döner", "Pilav", "Makarna", "İşkembe", "Kola", "Ayran", "Fanta", "Çamlıca", "Su", "Çay", "Cappy" };

        public static double[] Fiyat = new double[] {0, 3, 3, 2, 2.5, 2.5, 3.5, 2, 2, 1, 2, 1,0.75, 1.5, 2 };

        public static double Adet;
        public static double Toplam1=0;
        public static double Toplam2=0;

        public static void Hesap(int j)
        {
            Console.Write("Kaç Adet "+ Menu[j]+"İstiyorsunuz:");
            Adet = Convert.ToDouble(Console.ReadLine());
            Toplam1 = Fiyat[j] * Adet;
            Toplam2 += Toplam1;
        }

        static void Main(string[] args)
        {
           

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************Industryolog Akademi********************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Giriş İçin Bir Tuşa Basınız");
            Console.ReadKey();

            int Secim, i, Secim2;

            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("*       YİYECEKLER            **         İÇECEKLER           *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 1-   Kuru fasulye: 3.00 TL  ** 8-    Kola:    2.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 2-   Çiğ köfte: 3.00 TL     ** 9-    Ayran:   1.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 3-   Çorba:    2.00 TL      ** 10-   Fanta:   2.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 4-   Döner:    2.50 TL      ** 11-   Çamlıca: 1.00 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 5-   Pilav:    2.50 TL      ** 12-   Su:      0.75 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 6-   Makarna:  3.50 TL      ** 13-   Çay:     1.50 TL      *");
            Console.WriteLine("*                             **                             *");
            Console.WriteLine("* 7-   işkembe:  2.00 TL      ** 14-   Cappy:   2.00 TL      *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("");

            Secim = 100;

            for (i = 1; i <= Secim; i++)
            {
                Console.WriteLine(" ");
                Console.Write("Alacağınız Ürün Numarası:");
                Secim2 = Convert.ToInt16(Console.ReadLine());

                switch (Secim2)
                {
                    case 1: Hesap(1); break;
                    case 2: Hesap(2); break;
                    case 3: Hesap(3); break;
                    case 4: Hesap(4); break;
                    case 5: Hesap(5); break;
                    case 6: Hesap(6); break;
                    case 7: Hesap(7); break;
                    case 8: Hesap(8); break;
                    case 9: Hesap(9); break;
                    case 10: Hesap(10); break;
                    case 11: Hesap(11); break;
                    case 12: Hesap(12); break;
                    case 13: Hesap(13); break;
                    case 14: Hesap(14); break;

                    default: Console.WriteLine("Menüde böyle bir seçim yok "); break;
                }

                Console.WriteLine("");
                Console.Write("başka isteğiniz var mı? (E/H) ");
                string cev = Console.ReadLine();
                if ((cev == "h") || (cev == "H") || (cev == "hayır") || (cev == "HAYIR"))
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Toplam Tutar:{0:C}", Toplam2);

            Console.ReadKey();

        }
    }
}

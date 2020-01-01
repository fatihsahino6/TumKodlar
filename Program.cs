using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumKodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASAL SAYI
            //for (int f = 0; f < 10000; f++)
            //{
            //    int asal = 0;
            //    Console.WriteLine("Bir sayı giriniz : ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi == 1)
            //    {
            //        Console.WriteLine("2 veya 2 den büyük sayi girin");
            //    }
            //    else
            //    {
            //        for (int i = 2; i < sayi; i++)
            //        {
            //            if (sayi % i == 0)
            //            {
            //                asal++;
            //                break;
            //            }
            //        }

            //        if (asal == 0)
            //        {
            //            Console.WriteLine("Girilen sayi asaldir");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Girilen sayi asal değildir");
            //        }
            //    }
            //    Console.ReadKey();
            //}
            // -------------------------------------------------------------

            //TRY-CATCH

            //try
            //{
            //    double sayi = 5;
            //    object _objsayi = sayi;//Boxing: Değer tipinin object tipine  dönüştürülmesi.

            //    int _sayi = (int)_objsayi;//Unboxing :  Daha önceden boxing yapılmış değer tipinin tekrar kendi tipine dönüştürülmesi.

            //    string deneme = "5";
            //    int _deneme = int.Parse(deneme);

            //    _deneme = Convert.ToInt32(deneme);
            //    byte number = 5;
            //    int _number = number; //Implicit Type Casting
            //    int sayi3 = 5;
            //    byte number3 = sayi3;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Fatih");
            //    throw;
            //}
            //-------------------------------------------------------------
            //checked
            //{
            //    int sayi = 5;
            //    byte _sayi = (byte)sayi;
            //    Console.WriteLine(_sayi);
            //    Console.ReadKey(); 
            //}
            // Object tipi : Bütün tipler object tipinden türetilmiştir. Referans tipidir.
            //---------------------------------------------------------------
            //Tip Güvenliği - Type Safety
            //Explicit Type Casting
            //Parantez() ile yapılan dönüşümler değer tipinden değer tipine yapılır. İstisna : Object -> Değer tipine
            //-------------------------------------------------------------
            //try
            //{
            //    int sayi = 5;
            //    byte _sayi = sayi;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Fatih");
            //    throw;
            //}
            //---------------------------------------------------------
            //double sonuc;
            //Console.WriteLine("1. Sayiyi giriniz");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("2. Sayiyi giriniz");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlemi seciniz. 1/Toplama 2/Çıkarma 3/Çarpma 4/Bölme");
            //byte islem = byte.Parse(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1:
            //        sonuc = a + b;
            //        Console.WriteLine(sonuc);
            //        break;
            //    case 2:
            //        if (a > b)
            //        {
            //            sonuc = a - b;
            //            Console.WriteLine(sonuc);
            //        }
            //        else
            //        {
            //            sonuc = b - a;
            //            Console.WriteLine(sonuc);
            //        }
            //        break;
            //    case 3:
            //        sonuc = a * b;
            //        Console.WriteLine(sonuc);
            //        break;
            //    case 4:
            //        sonuc = (a / b);
            //        Console.WriteLine(sonuc);
            //        break;
            //    default:
            //        break;
            //}
            //Console.ReadKey();
            //---------------------------------------------------------------
            //for (int f = 0; f < 10000; f++)
            //{


            //    Console.WriteLine("1. sayiyi giriniz");
            //    byte a = byte.Parse(Console.ReadLine());
            //    Console.WriteLine("2. sayiyi giriniz");
            //    byte b = byte.Parse(Console.ReadLine());
            //    Console.WriteLine("Hangi sayilar toplansin 1/Tek 2/Çift");
            //    int c = int.Parse(Console.ReadLine()) == 1 ? 1 : 0;
            //    int sonuc = 0;
            //    for (int i = a; i <= b; i++)
            //    {
            //        if (i % 2 == c)
            //        {
            //            sonuc += i;
            //        }

            //    }
            //    Console.WriteLine("1. sayidan 2. sayiya kadar olan sayilarin toplamı : " + sonuc);
            //}
            //------------------------------------------------------------------
            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine("1. Sayiyi giriniz: ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("2. Sayiyi giriniz: ");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz :\n " +
            //        "1/Toplama \n" +
            //        "2/Çıkarma \n" +
            //        "3/Çarpma \n" +
            //        "4/Bölme \n" +
            //        "5/Faktoriyel alma \n" +
            //        "6/2 sayi arasindaki sayilari toplama\n" +
            //        "7/2 sayi arasindaki tek veya çift sayilari toplama\n");
            //    byte c = byte.Parse(Console.ReadLine());
            //    int sonuc = 0;
            //    int sonuc2 = 1;
            //    if (c == 1)
            //    {
            //        sonuc = a + b;
            //        Console.WriteLine(sonuc);

            //    }
            //    else if (c == 2)
            //    {
            //        sonuc = a - b;
            //        Console.WriteLine(sonuc);
            //    }
            //    else if (c == 3)
            //    {
            //        sonuc = a * b;
            //        Console.WriteLine(sonuc);
            //    }
            //    else if (c == 4)
            //    {
            //        sonuc = a / b;
            //        Console.WriteLine(sonuc);
            //    }
            //    else if (c == 5)
            //    {
            //        Console.WriteLine("1. Sayinin mi 2. Sayinin mi faktoriyelini almak istersiniz");
            //        byte d = byte.Parse(Console.ReadLine());
            //        if (d == 1)
            //        {
            //            for (int f = 1; f <= a; f++)
            //            {
            //                sonuc2 *= f;


            //            }
            //            Console.WriteLine(sonuc2);
            //        }
            //        else if (d == 2)
            //        {
            //            for (int y = 1; y <= b; y++)
            //            {
            //                sonuc2 *= y;


            //            }
            //            Console.WriteLine(sonuc2);
            //        }
            //    }
            //    else if (c == 6)
            //    {
            //        for (int g = a; g <= b; g++)
            //        {
            //            sonuc += g;
            //        }
            //        Console.WriteLine(sonuc);
            //    }
            //    else if (c == 7)
            //    {
            //        Console.WriteLine("1:TEK 2:CIFT");
            //        byte u = byte.Parse(Console.ReadLine());

            //        for (int o = a; o < b; o++)
            //        {
            //            if (u == 1 && o % 2 == 1)
            //            {
            //                sonuc += o;
            //            }
            //            else if (u == 2 && o % 2 == 0)
            //            {
            //                sonuc += o;
            //            }
            //        }
            //    }
            //    Console.WriteLine(sonuc);
            //}
            //-----------------------------------------------------
            //DİZİLER
            //int[] fatih = new int[3];
            //fatih[0] = 58;
            //fatih[1] = 06;
            //fatih[2] = 34;
            //for (int i = 0; i < fatih.Length; i++)
            //{
            //    Console.WriteLine(fatih[i]);
            //}


            //int[] dizi = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(100);
            //}
            //Array.Sort(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //Console.ReadKey();



            //Console.WriteLine("Kaç tane isim girmek istiyorsunuz");
            //int isim = int.Parse(Console.ReadLine());
            //string[] dizi = new string[isim];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //      
            //}
            //Array.Sort(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //for (int i = 0; i < 5; i++)
            //{


            //    for (int j = 0; j <=i; j++)
            //    {

            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            //int[,] dizi = new int[3, 2];
            //Random rnd = new Random();
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{

            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        dizi[i, j] = rnd.Next(100);
            //    }
            //}
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        Console.Write(dizi[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------
            //DO_WHİLE
            //double sayi1 = 0;
            //double toplam = 0;
            //double sayac = 0;
            //double toplam2;
            //do
            //{

            //    Console.WriteLine("Sayi giriniz");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi1;
            //    sayac++;


            //} while (sayi1 != 0);
            //sayac--;
            //Console.WriteLine(toplam);
            //Console.WriteLine(toplam2 = toplam / (sayac - 1));
            //Console.ReadKey();
            //----------------------------------------------------------------------
            //Sesli-Sessiz Harf
            //char[] sesli =
            // {
            //    'a','e','ı','i','o','ö','u','ü'

            //};
            //char[] sessiz =
            //{
            //            'b','c','ç','d','f','g','ğ','h','j','k','l','m','n','p','r','s','ş','t','v','y','z',

            //};
            //int adet = 0;
            //int adet2 = 0;
            //Console.WriteLine("Herhangi bir cümle giriniz");
            //string cumle = Console.ReadLine().ToLower();
            //Console.WriteLine("Sesli harf mi/1 Sessiz harfmi/2");
            //byte u = byte.Parse(Console.ReadLine());
            //if (u == 1)
            //{
            //    for (int i = 0; i < cumle.Length; i++)
            //    {
            //        for (int f = 0; f < sesli.Length; f++)
            //        {
            //            if (cumle[i] == sesli[f])
            //            {
            //                Console.WriteLine(cumle[i]);
            //                adet++;
            //            }

            //        }

            //    }
            //    Console.WriteLine("Sesli Harf Sayisi : {0}", adet);


            //}
            //else if (u == 2)
            //{
            //    for (int b = 0; b < cumle.Length; b++)
            //    {
            //        for (int c = 0; c < sessiz.Length; c++)
            //        {
            //            if (cumle[b] == sessiz[c])
            //            {
            //                Console.WriteLine(cumle[b]);
            //                adet2++;
            //            }
            //        }

            //    }
            //    Console.WriteLine("Sessiz Harf Sayisi : {0}", adet2);

            //}

            //-------------------------------------------------------------------------
            //FAKTÖRİYEL VE ÜS ALMA
            //int sonuc = 1;
            //Console.WriteLine("Herhangi bir sayi giriniz");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlemi seçin 1/Üst Almak 2/Faktoriyel Alma");
            //byte islem = byte.Parse(Console.ReadLine());
            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine("Kaç defa üst almak istersiniz");
            //        short ust = short.Parse(Console.ReadLine());
            //        for (int i = 0; i < ust; i++)
            //        {
            //            sonuc = sonuc * a;

            //        }
            //        Console.WriteLine(sonuc);
            //        break;
            //    case 2:
            //        for (int i = 1; i <= a; i++)
            //        {
            //            sonuc *= i;
            //        }
            //        Console.WriteLine(sonuc);
            //        break;
            //    default:
            //        break;
            //}
            //Console.ReadKey();
        }
    }
}

    


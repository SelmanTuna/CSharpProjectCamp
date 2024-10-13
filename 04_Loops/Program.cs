using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            //Döngüler
            //1+2+3+4+5+6; 
            // makine bu şekilde toplar  :  1+2=3 3+3=6 6+4=10 10+5=15 15+6=21 

            //for(x;  y; z;)
            //x: başlangıç
            //y: bitiş
            //z: artış-azalış

            //int i;
            //for( i = 1; i <= 5; i++ )
            //{
            //    Console.WriteLine("C# Egitim Kampi");
            //}

            //for(int i=0; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazilmasini istediginiz adeti giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i=0; i<finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet.");
            //}


            #endregion

            #region For Döngüsü ile karar yapilari

            //for(int i=0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for(int i=0; i<=10; i++)
            //{
            //    totalValue += i;  //totalValue = totalValue + i;
            //}
            //Console.WriteLine(totalValue);


            //int totalDoubleNumber = 0;

            //for(int i=0; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalDoubleNumber += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------------");
            //Console.WriteLine(totalDoubleNumber);

            //int totalCount = 0;

            //for(int i=1; i<=60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalCount+=1; //totalCount++; 
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("***********");
            //Console.WriteLine(totalCount);

            // bakteri üreten bir odamız var, burada bir bakteri her saatin sonunda 2 ye bölünerek artıyor, ör: 1.sa: 1  2.sa: 2  3.sa: 4  4.sa:8 5.sa:16 .... 24 sa sonunda kaç bakteri oluşur??

            //int bacterium = 1;

            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".saat sonunda : " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //While(Şart yazılır)
            //{
            //  İŞlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Döngüler!!");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);                    
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("1-10 arasindaki sayilarin toplami: " + sum);


            #endregion

            #region Örnek soru

            //Klavyeden girilen 3 basamaklı sayinin basamaklari toplamini hesaplayan kodu yaziniz..

            //Console.Write("Lütfen üç basamakli bir sayi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int ones, tens, hundreds;

            //ones = number % 10; //456 10 a bölümünden kalan 6 dir.
            //hundreds = number / 100; //456/10=4.56 == 4 tür.
            //tens = (number / 10) % 10;  //  ( 456/10 ==4  ) 10 a bölümünden kalan 5 dir.

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //sum = ones + tens + hundreds;

            //Console.WriteLine("Basamaklari Toplami: " + sum);

            #endregion

            string a = "abc";
            string b = "ab" + "c";
            Console.WriteLine(a+ " " +b);

            Console.Read();
        }
    }
}

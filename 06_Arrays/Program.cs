using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri

            // 2.4.6.8 (çift sayilar)

            //degiskenTuru [] DiziAdi= new degiskenTuru[elemanSayisi]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "London";
            //cities[3] = "New York";
            //cities[4] = "Paris";

            //Console.Write(cities[2]);
            //Console.WriteLine(cities[5]); // dizi sınırı dışında hata fırlatır..

            //Çift Sayilar Dizisi...
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[4] = 24;
            //numbers[5] = 42;
            //numbers[7] = 424;

            ////Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[6]); // indekte bir değer yoksa ya da atanmadıysa default değeri 0 gelir.


            //string[] cities = { "Prag", "Atina", "Roma", "Ankara", "İzmir" };
            //Console.WriteLine(cities[2]); // ==ROMA, 
            //Console.WriteLine(cities[5]); // hata firlatir, dizi sinirinin dişinda.

            #endregion

            #region Dizideki tüm elemanları listelemek

            //string[] colors = { "Sari", "Kirmizi", "Beyaz", "Mavi", "Yesil", "Turuncu", "Pembe" };
            //for(int i=0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]); 
            //}

            //dizi icerisindeki 3 e tam bolunen sayilari yazdiralim.
            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 }; //array
            //for(int i = 0; i < numbers.Length; i++) //loop.
            //{
            //    if (numbers[i] % 3 == 0) // if clause.
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'f', '&', '%', '£', 'h' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.Write(symbols[i]);
            //}

            //Dizideki en büyük elemani bulan kodu yazalim.

            //int[] customArray = { 47, 85, 95, 41, 1225, 635, 789, 86, 100 };

            //int maxNumber = customArray[0];

            //for(int i = 0; i < customArray.Length; i++)
            //{
            //    if (customArray[i] > maxNumber)
            //    {
            //        maxNumber = customArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizilerde methodlar

            //string[] persons = { "ali", "ahmet", "hakan", "ipek", "ceren", "ufuk" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 23, 543, 12, 678, 4, 567, 876 };
            //Array.Sort(numbers); // dizi elemanlarını küçükten büyüğe siralar.
            //for(int i=0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "sude", "cem", "gonca", "salih" };
            //int index = Array.IndexOf(customers, "gonca");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 43, 54, 654, 12, 34, 755, 76, 98 };
            //Console.WriteLine("Dizinin En Büyük Elemani:" + numbers.Max());
            //Console.WriteLine("Dizinin En Kücük Elemani:" + numbers.Min());


            #endregion

            #region Kullanicidan Deger Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //for(int i=0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 40, 20, 50, 70 };
            //int sum = 0;

            //for(int i=0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = new int[4];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($" {i + 1}. Sayiyi Giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("**************************");

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];                
            //}
            //Console.Write("Toplam: " + sum);


            //Dizideki çift ve Tek sayilari yazdiralim.

            //int[] numbers = { 10, 31, 43, 52, 65, 86, 94, 34 };

            //Console.WriteLine("Cift Sayilar: ");
            //Console.WriteLine("---------------");
            //Console.WriteLine();

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek Sayilar: ");
            //Console.WriteLine("-------------");
            //Console.WriteLine();

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}

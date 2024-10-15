using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            // foreach(Degisken Türü - Degisken Adi - In - Liste/Koleksiyon/Dizi)

            //string[] cities = { "milano", "roma", "budapeste", "paris", "saraybosna" };

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 987, 543, 23, 122, 43, 6789, 543, 333, 989 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //// 2 ye tam bolunen sayiları yazdir
            //int[] numbers = { 21, 43, 64, 766, 886, 65, 343, 22, 12221, 2, 87, 65, 987 };
            //foreach(int mynumber in numbers)
            //{
            //    if (mynumber % 2 == 0)
            //    {
            //        Console.WriteLine(mynumber);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int totalNumber = 0;

            //foreach(int count in numbers)
            //{
            //    totalNumber += count;
            //    //Console.WriteLine(totalNumber); bu satirda yazdırıldiğinda bir önceki toplam ve son toplam şeklinde alt alta satır satır toplayarak yazdiracak.
            //}
            //Console.Write("Toplam: " + totalNumber);

            //List<int> numbers = new List<int>()
            //{
            //    1,4,7,2,8,6
            //};
            ////Console.WriteLine(numbers);// Listede elemanlar yazdırılmaz..
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //bir kelimeyi harflarine ayıran kodu yazalım

            //string wordList = "HelloWorld";
            //foreach(char w in wordList)
            //{
            //    Console.WriteLine(w);
            //}
            #endregion

            // Ör: klavyeden öğrenci sayisi, öğrenci ismi, sinav notlari , ortalamalarini hesaplatalim.

            #region Örnek Uygulama(algoritma yaklaşımı)

            Console.WriteLine("***** C # Egitim Kampi Sinav Uygulamasi *****");
            Console.WriteLine();

            //siniftaki öğrenci sayisini kullanicidan alma.
            Console.WriteLine("------------------------------------");
            Console.Write("Sinifinizda Kac Ogrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            //ögranci isimelerini ve not ortalamalarini tutan diziler

            string[] studentNames = new string[studentCount];
            double[] examAverages = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamValue = 0;

                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]} İsimli Öğrencinin {j + 1}. Sınav Notunu Giriniz: ");
                    double examValue = double.Parse(Console.ReadLine());
                    totalExamValue += examValue; // notları topluyoruz..
                }
                Console.WriteLine();
                examAverages[i] = totalExamValue / 3;
            }          

            //Sinav ortalamalari
            for (int i=0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------------");

                Console.WriteLine($"{studentNames[i]} İsimli Öğrencinin Ortalaması: { examAverages[i]}");
                Console.WriteLine();
                //Console.WriteLine();

                //Öğrencilerin gecip kalma durumlari

                if (examAverages[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} İsimli Öğrenci: GEÇER");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli Öğrenci: KALIR");
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}

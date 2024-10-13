using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen sifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre dogru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre yanlis.");
            //}

            //string capital, city;
            //Console.Write("Baskenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi Giriniz: ");            
            //city = Console.ReadLine();

            //if(capital=="ankara" && city == "türkiye")
            //{
            //    Console.Write("bilgiler dogru,tebrikler");
            //}
            //else
            //{ 
            //    Console.Write("hatalı bilgiler, malesef");
            //}

            //int number;
            //Console.Write("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 41)
            //{
            //    Console.Write("Sayi dogru.");

            //}
            //else
            //{
            //    Console.Write("Sayi yanlis.");
            //}


            //int exam1, exam2, exam3, average;
            //string result;
            //result = "Error!";

            //Console.Write("Sinav1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinav Ortalamanız: " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = "Sonuc vasat";
            //}
            //if (average > 50 && average <= 70)
            //{
            //    result = "Sonuc orta";
            //}
            //if (average > 70 && average <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuc süper";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen sehir ismi giriniz: ");
            //city = Console.ReadLine();

            //if(city=="adana" || city=="ankara" || city=="bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Sehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Sehir mevcut degil!");

            //}

            //Console.Write("Lütfen kullanici adini giriniz : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanici gecerli degil!");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz.");
            //}

            #endregion

            #region Mod İslemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.Write(result);


            //Console.WriteLine("Birinci Sayiyi Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci Sayiyi Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayinin İkinci sayiya bolümünden kalan: " + result);

            //Console.Write("Bir Sayi Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayi Cifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayi Tektir.");
            //}

            //char team;
            //Console.Write("Lütfen sembolu giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' || team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team=='f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");

            //}
            //if(team=='b' || team == 'B')
            //{
            //    Console.WriteLine("Besiktas"); 
            //}

            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("********* C# Egitim Kampi Restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İcecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayini görmek istediginiz menu seciniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabagı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Firinda Somun");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Corbalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Domates Corbasi");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Corbalar-----------------");

            //}

            //if(menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tuna Balikli Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar--------------");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İcecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İcecekler-----------");
            //}

            //if (menuItem=="5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlilar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilece");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sutlac");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlilar--------------");
            //}           

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girisi Yapiniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Subat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayis"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylul"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasim"); break;
            //    case 12: Console.Write("Aralik"); break;
            //    default: Console.Write("Hatali Veri Girisi!"); break;
            //}

            #endregion

            #region Switch case hesap makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayiyi Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sayiyi Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediginiz İslemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Cikarma: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolme: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpma:" + result);
            //        break;
            //    default: Console.WriteLine("Hatalı İslem!");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}

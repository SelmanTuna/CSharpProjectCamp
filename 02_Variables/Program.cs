using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.86;
            //Console.WriteLine(number);

            //Console.WriteLine("*******Fiyat Listesi*******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyati: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyati: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyati: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyati: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyati: " + tomatoPrice + " TL");

            //Console.WriteLine();

            //double appleWeight, orangeWeight, strawberryWeight, potatoWeight, tomatoWeight;

            //appleWeight = 1.245;
            //orangeWeight = 2.650;
            //strawberryWeight = 0.750;
            //potatoWeight = 4.859;
            //tomatoWeight = 3.745;

            //double appleTotalPrice = applePrice * appleWeight;
            //double orangeTotalPrice = orangePrice * orangeWeight;
            //double strawberryTotalPrice = strawberryPrice * strawberryWeight;
            //double potatoTotalPrice = potatoPrice * potatoWeight;
            //double tomatoTotalPrice = tomatoPrice * tomatoWeight;

            //Console.WriteLine("Alinan Urun : " + "Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleWeight + " - Toplam Tutar: " +  appleTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun : " + "Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeWeight + " - Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun : " + "Cilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryWeight + " - Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun : " + "Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoWeight + " - Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alinan Urun : " + "Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoWeight + " - Toplam Tutar: " + tomatoTotalPrice + " TL");

            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Toplam Alısveris Tutari: " + shoppingTotalPrice + "TL");


            #endregion

            #region Char Değişkenler

            // char değiğşkenler ' ' içerisinde kullanılır..

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri(string)

            //Console.WriteLine("****CSharp Hava Yolları Yolcu" +
            //    " Bilgisi****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu TC : " +passengerIdentityNumber + " - Yolcu Ad Soyad :  " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge ); 

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldiğiniz Ayakkabi Sayisini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldiğiniz Bilgisayar Sayisini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldiğiniz Sandalye Sayisini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldiğiniz Televizyon Sayisini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice );

            #endregion

            #region Klavyeden Ondalikli Sayi işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sinav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sinav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sinav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("Sinav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seciniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Sectiginiz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}

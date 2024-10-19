using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //Geriye deger dondurmeyen metotlar Void.

            //Customer --> Listele, Ekle, Sil, Güncelle 
            // void 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");                
            //}
            //CustomerList();
            //Console.WriteLine();
            //CustomerList();
            //Console.WriteLine();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 3;
            //    int z = x + y;
            //    Console.Write(z);
            //}
            //Sum();

            #endregion

            #region Geriye deger dondurmeyen  String parametreli methodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Ali Yücetürk");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Ahmet" , "Kaya" );
            //CustomerCard("Ayşe", "Fidan");

            #endregion

            #region Geriye deger dondurmeyen Int parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6); 

            #endregion

            #region geriye deger döndüren methodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye deger donduren parametreli metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adini Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            ////Console.WriteLine(CountryCard("Ukrayna", "Kiev", "Sarı-Yesil"));       

            #endregion

            #region Geriye deger donduren Int parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(3, 5));
            //Console.WriteLine(Sum(32, 54));
            //Console.WriteLine(Sum(213, 453));
            #endregion

            #region Ornek uygulama

            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sinavi gecti," + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sinavi gecemedi," + " Ortalama: " + result;    
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 50, 72, 61));
            //Console.WriteLine();
            //Console.WriteLine(ExamResult("Elif", 45, 30, 10));

            #endregion
            


            Console.Read();
        }
    }
}

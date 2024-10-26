using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create - Read - Update - Delete komutlaridir.

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            #region Kategori Ekleme İslemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //// ex. connection ==> " data source=' server name'; initial catalog='database adi'; integrated security=true "

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UDCIU0S\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; Integrated Security= true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İslemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine()); 

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UDCIU0S\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert Into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName); 
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi.");

            #endregion

            #region Ürün Listeleme İslemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UDCIU0S\\SQLEXPRESS ; Initial Catalog=EgitimKampiDb ; Integrated Security= true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command); //db den data çekerken köprü görevi görmesi için bir adapter kullanıyoruz!!
            //DataTable dataTable = new DataTable();             //çekilen datalar geçici bellekte tutulmalı, datatable class ile.
            //adapter.Fill(dataTable);                // köprü ile çekilen datalar bellekten alınarak datatable nesnesine doldurulur.

            //foreach (DataRow row in dataTable.Rows )   // datatable da doldurulan table Row ları okuyup göstermek için döngü kullanıyoruz
            //{
            //    foreach(var item in row.ItemArray)   // datatable da doldurulan table Row item ları okuyup göstermek için döngü kullanıyoruz
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İslemi

            //int productId;
            //Console.Write("Silinecek ürün Id: ");
            //productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UDCIU0S\\SQLEXPRESS ; Initial Catalog=EgitimKampiDb ; Integrated Security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla silindi.");

            #endregion

            #region Urun Guncelleme İslemi

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-UDCIU0S\\SQLEXPRESS;Initial Catalog=EgitimKampiDb; Integrated Security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set productName=@productName,productPrice=@productPrice Where productId=@productId", connection);

            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme İşlemi Başarıyla Tamamlandı."); 

            #endregion

            Console.Read();


        }
    }
}

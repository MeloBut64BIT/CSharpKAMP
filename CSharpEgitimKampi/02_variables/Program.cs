using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Duoble Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);



            //string apple = "Elma";
            //string orange = "Portakal";
            //string strawberry = "Çilek";
            //string potato = "Patates";
            //string tomato = "Domates";

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice= applePrice * appleGram;
            //double orangeTotalPrice= orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice= potatoPrice * potatoGram;
            //double tomatoTotalPrice= tomatoPrice * tomatoGram;

            //double totalPrice= appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("***** FİYAT LİSTESİ *****");
            //Console.WriteLine();
            //Console.WriteLine("ÜRÜN ADI: " + apple + "      - BİRİM FİYATI: " + applePrice + "      - GRAMAJ: " + appleGram + "      - ÖDENECEK TUTAR: " + appleTotalPrice);
            //Console.WriteLine("ÜRÜN ADI: " + orange + "     - BİRİM FİYATI: " + orangePrice + "     - GRAMAJ: " + orangeGram + "     - ÖDENECEK TUTAR: " + orangeTotalPrice);
            //Console.WriteLine("ÜRÜN ADI: " + strawberry +" - BİRİM FİYATI: " + strawberryPrice + " - GRAMAJ: " + strawberryGram + " - ÖDENECEK TUTAR: " + strawberryTotalPrice);
            //Console.WriteLine("ÜRÜN ADI: " + potato + "     - BİRİM FİYATI: " + potatoPrice + "     - GRAMAJ: " + potatoGram + "     - ÖDENECEK TUTAR: " + potatoTotalPrice);
            //Console.WriteLine("ÜRÜN ADI: " + tomato + "     - BİRİM FİYATI: " + tomatoPrice + "     - GRAMAJ: " + tomatoGram + "     - ÖDENECEK TUTAR: " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("toplam tutar");
            //Console.WriteLine(totalPrice);




            #endregion

            #region Char Değişkenler

            // tek tırnak ('') ile atama yapılır.

            //char name;
            //name = 'a';

            //Console.WriteLine(name);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** MELO HAVA YOLLARI YOLCU BİLGİSİ *****");
            //Console.WriteLine();

            //string passengerName, passengerSurName, passengerDistrict, passengerCity, passengerAge, 
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurName = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("--------------------");

            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurName);
            //Console.WriteLine("Adres Bilgisi: " +  passengerDistrict + "/" + passengerCity);
            //Console.WriteLine("Yaş Bilgisi:  " + passengerAge);
            //Console.WriteLine("TC NO: " + passengerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            // int shoesPrice, computerPrice, chairPrice, tvPrice;

            // shoesPrice = 500;
            // computerPrice = 10000;
            // chairPrice = 5000;
            // tvPrice = 25000;

            // int shoesCount, computerCount, chairCount, tvCount;

            // Console.WriteLine("*****FİYAT LİSTESİ *****");
            // Console.WriteLine("----------------------------------");

            // Console.WriteLine("1-Ayakkabı Fiyatı: " + shoesPrice + " TL");
            // Console.WriteLine("2-Bilgisayar Fiyatı: " + computerPrice + " TL");
            // Console.WriteLine("3-Sandalye Fiyatı: " + chairPrice + " TL");
            // Console.WriteLine("4-Televizyon Fiyatı: " + tvPrice + " TL");

            // Console.WriteLine("----------------------------------");



            // Console.Write("Lütfen Ayakkabı Adedi Giriniz: ");
            // shoesCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen Bilgisayar Adedi Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen Sandalye Adedi Giriniz: ");
            // chairCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen Televizyon Adedi Giriniz: ");
            // tvCount = int.Parse(Console.ReadLine());

            // int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            // Console.WriteLine();
            // Console.WriteLine("Toplam Ödeme: " + totalPrice + " TL" );




            #endregion

            #region Kalvyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.Write("Sınav Ortalamanız: " + result);


            #endregion

            #region Kalvyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);


            #endregion


            Console.Read();

        }
    }
}

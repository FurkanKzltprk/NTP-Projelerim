using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProjeEB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;

            Ogrenci ogrenci1 = new Ogrenci(1, "furkan", "k", 50, 40, 73, "Fırat Üniversitesi");


            Console.WriteLine("Uygulamamıza Hoş geldiniz ... Yapmak İstediğiniz işlemi seçiniz : ");

            while (kontrol)
            {
                Console.WriteLine("***************");
                islemleriGoster();
                Console.WriteLine("***************");



                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster(); break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.ogrenciOrtBul(); break;
                        Console.WriteLine("Öğrencinin Ortalaması :" + ogrenciOrtalama);

                    case "3":
                        ogrenci1.okulGetir(); break;
                    case "4":
                        kontrol = false;
                        break;


                }


            }




        }
        static void islemleriGoster()
        {
            Console.WriteLine("1-Öğrenci Bilgileri Göster");
            Console.WriteLine("2-Öğrencinin Ortalamasını Göster");
            Console.WriteLine("3-Öğrencinin okulunu göster");
            Console.WriteLine("4-Çıkış yap");

        }
    }
}

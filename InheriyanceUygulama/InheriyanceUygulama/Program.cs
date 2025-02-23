using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Çalışan uygulamasına hoş geldiniz ... ");
                Console.WriteLine("1-Yazılımcı işlemleri");
                Console.WriteLine("2-Yönetici işlemleri");
                Console.WriteLine("Çıkış için q'ya basın");
                Console.WriteLine("*****************************");

                string secilenIslem = Console.ReadLine();
                Console.WriteLine("*****************************");


                if (secilenIslem == "q")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                }


                else if (secilenIslem == "1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "furkan", "kt", "Java,C#,C++");
                  

                    while (true)
                    {
                        Console.WriteLine("yazılımcı işlevi seçiniz :");
                        Console.WriteLine("1-Format at");
                        Console.WriteLine("2-Yazılımcının bilgilerini göster");
                        Console.WriteLine("3-Çıkış için q'ya basınız");
                        Console.WriteLine("*****************************");

                        string yazilimciIslem = Console.ReadLine();
                        Console.WriteLine("*****************************");



                        if (yazilimciIslem == "q")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor...");
                            Console.WriteLine("*****************************");

                            break;

                        }
                        else if (yazilimciIslem == "1")
                        {
                            Console.Write("İşletim sistemi giriniz : ");
                            string isletimSistemi = Console.ReadLine();

                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if (yazilimciIslem == "2")
                        {
                            yazilimci.bilgileriGoster();

                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz! ");
                        }
                    }
                }
                else if (secilenIslem == "2")
                {
                    Yonetici yonetici = new Yonetici(2, "Gençay", "yıldız", 12);
                   

                    while (true)
                    {
                        Console.WriteLine("Yonetici işlevi seçiniz");
                        Console.WriteLine("1-Zam yap");
                        Console.WriteLine("2-Yöneticinin bilgilerini göster");
                        Console.WriteLine("3-Çıkış için q'ya basınız");
                        Console.WriteLine("*****************************");

                        string yoneticiIslem = Console.ReadLine();
                        Console.WriteLine("*****************************");

                        if (yoneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor ...");
                            Console.WriteLine("*****************************");

                            break;
                        }
                        else if (yoneticiIslem == "1")
                        {
                            Console.Write("Zam mikatrını giriniz :");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("*****************************");

                            yonetici.zamYap(zamMiktari);
                            Console.WriteLine("*****************************");


                        }
                        else if (yoneticiIslem == "2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz"); 
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem giriniz !");
                    Console.WriteLine("*****************************");

                    Console.Write("islem seciniz :");  
                    secilenIslem = Console.ReadLine();
                    Console.WriteLine("*****************************");


                }

            }

        }
    }
}

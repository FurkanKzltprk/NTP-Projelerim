using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şekil uygulamasına hoşgeldiniz !");
            while (true)
            {
                Console.WriteLine("Aşağıdaki işlemlerden seçiniz : ");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1-Dikdörtgen işlemleri");
                Console.WriteLine("2-Üçgen işlemleri");
                Console.WriteLine("3-Kare işlemleri");
                Console.WriteLine("4-Programı sonlandırmak için (q) ya basınız");
                Console.WriteLine("--------------------------------------------");

                Console.Write("seçilen işlem : ");  string secim = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");


                if (secim == "q")
                {
                    break;

                }
                else if (secim == "1")
                {

                    while (true)
                    {



                        Console.WriteLine("1- Dikdörtgen alan hesapla");
                        Console.WriteLine("2- Dikdörtgen bilgileri göster ");
                        Console.WriteLine("3- Dikdörtgenden çıkış yap (q)");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("seçilen işlem : ");  string secimdikdortgen = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------");


                        if (secimdikdortgen == "1")
                        {
                            Console.Write("kısa kenarı giriniz :");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("uzun kenarı giriniz :");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------");

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kisakenar, uzunkenar);
                            dikdortgen.sekilHesapla();


                        }
                        else if (secimdikdortgen == "2")
                        {
                            Console.Write("kısa kenarı giriniz :");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("uzun kenarı giriniz :");
                            int uzunkenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------");

                            Dikdortgen dikdortgen = new Dikdortgen("Dikdortgen", kisakenar, uzunkenar);
                            dikdortgen.sekilBilgileriGoster();
                        }
                        else if (secimdikdortgen == "q")
                        {
                            Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor ...");
                            break;
                        }
                    }


                }
                else if (secim == "2")
                {

                  

                    while (true)
                    {
                        Console.WriteLine("1- Üçgenin alanını hesapla");
                        Console.WriteLine("2- Üçgenin bilgilerini göster ");
                        Console.WriteLine("3- Üçgenden çıkış yap (q)");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Seçilen işlem : "); string secimucgen = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------");


                        if (secimucgen == "1")
                        {
                            Console.Write("Üçgenin taban alanını giriniz : ");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Üçgenin yüksekliğini giriniz : ");
                            int yükseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen", tabanalani, yükseklik);
                            Console.WriteLine("--------------------------------------------");

                            ucgen.sekilHesapla();
                        }
                        else if (secimucgen == "2")
                        {
                            Console.Write("Üçgenin taban alanını giriniz : ");
                            int tabanalani = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Üçgenin yüksekliğini giriniz : ");
                            int yükseklik = Convert.ToInt32(Console.ReadLine());
                            Ucgen ucgen = new Ucgen("Üçgen", tabanalani, yükseklik);
                            ucgen.sekilBilgileriGoster();

                        }
                        else if (secimucgen == "q")
                        {
                            Console.WriteLine("Üçgen işlemlerinden çıkılıyor");
                            break;

                        }



                    }


                }
                else if (secim == "3")
                {
                   

                    while (true)
                    {
                        Console.WriteLine("1-Karenin alanını hesapla  ");
                        Console.WriteLine("2-Karenin bilgilerini göster ");
                        Console.WriteLine("3-Kareden çıkış yap (q) ");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("seçilen işlem : "); string secimkare = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------");


                        if (secimkare == "1")
                        {
                            Console.Write("Karenin kenarını giriniz :");
                            int kenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------");

                            Kare kare = new Kare("kare", kenar);
                            kare.sekilHesapla();
                            Console.WriteLine("--------------------------------------------");


                        }
                        else if (secimkare == "2")
                        {
                            Console.WriteLine("Karenin kenarını giriniz :");
                            int kenar = Convert.ToInt32(Console.ReadLine());

                            Kare kare = new Kare("kare", kenar);
                            kare.sekilBilgileriGoster();

                        }
                        else if (secimkare == "q")
                        {
                            Console.WriteLine("Kare işlemlerinden çıkılıyor...");
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz");


                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    public class Ucgen : Sekil
    {
        public int tabanalani { get; set; }
        public int yukseklik { get; set; }

        public Ucgen(string isim, int tabanalani, int yukseklik) : base(isim)
        {
            this.tabanalani = tabanalani;
            this.yukseklik = yukseklik; 
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " nin alanı : "+ (tabanalani*yukseklik)/2);
            Console.WriteLine("--------------------------------------------");


        }
        public override void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + " nin bilgileri !");
            Console.WriteLine(getIsim() + " nin taban alanı : " + this.tabanalani);
            Console.WriteLine(getIsim() + " nin yüksekliği : " + this.yukseklik);
        }

    }
}

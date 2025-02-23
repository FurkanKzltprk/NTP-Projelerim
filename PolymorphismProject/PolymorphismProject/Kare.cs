using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    public class Kare : Sekil
    {
        public int kenar { get; set; }
        public Kare(string isim , int kenar) : base(isim)
        {
            this.kenar = kenar;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+" nin alanı:" + (kenar*kenar));
        }

        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine(getIsim() + " nin bilgileri !");
            Console.WriteLine(getIsim() + " nin kısa kenarı : " + this.kenar);
        }


    }
}

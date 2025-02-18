using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProjeEB
{
    public class Ogrenci
    {
        private int ogrno;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrno , string _isim, string _soyisim ,int _vize1 , int _vize2 , int _final , string _okulIsmi)
        {
            ogrno = _ogrno;
            isim = _isim;
            isim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
            
        }


        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası : " +ogrno);
            Console.WriteLine("Öğrenci İsmi : " + isim);
            Console.WriteLine("Öğrenci soyİsmi : " + soyisim);
            Console.WriteLine("Öğrenci vize1 : " + vize1);
            Console.WriteLine("Öğrenci vize2 : " + vize2);
            Console.WriteLine("Öğrenci final : " + final);
            Console.WriteLine("Öğrenci okul ismi : " + okulIsmi);

        }

        public double ogrenciOrtBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }
        public void okulGetir()
        {
            Console.WriteLine("Öğremcinin okul ismi : "+okulIsmi);  
        }



    }
}

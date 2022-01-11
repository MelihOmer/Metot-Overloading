using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out Parametreler
            string sayi = "999ssss";

           bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                System.Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSayi);
            }
            else
                System.Console.WriteLine("Başarısız");

            Metotlar metot = new Metotlar();
            metot.Topla(4,5,out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);
            
            //Metot Aşırı Yükleme -Overloading
            int ifade = 999;
            metot.EkranaYazdir(ifade.ToString());
            metot.EkranaYazdir(ifade);
            metot.EkranaYazdir("Melih Ömer "+"Kamar");
            //Metot İmzası
            //MetotAdı + Parametre sayısı + Parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
             toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri,string veri2)
        {
            System.Console.WriteLine(veri+veri2);
        }
    }

}

﻿using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("---------Metotlar----------");

            SepetaManager sepetManeger = new SepetaManager();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
            sepetManeger.Ekle2("Armut", "yeşil armut", 12,8);
            sepetManeger.Ekle2("Karpuz", "Diyarbakır", 82,96);
            sepetManeger.Ekle2("Elma", "Yeşil elma", 22,6 );

        }
    }
}

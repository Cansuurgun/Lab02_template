using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02_template
{
    class Program
    {
        public static void Main(string[] args)
        {
            Koordinat ilk = new Koordinat(3, 4);
            Koordinat ikinci = new Koordinat(7, 8);



            Daire daire = new Daire(ilk, 5);
            Dikdortgen dikdortgen = new Dikdortgen(ikinci, 3, 9);


            Hesap.cevreDaire(daire);


            Hesap.alanDaire(daire);
            Hesap.alanDiktortgen(dikdortgen);
            Hesap.merkezKoordinatDaire(daire);
            Hesap.merkezKoordinatDikdortgen(dikdortgen);

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}

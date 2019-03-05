using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02_template
{
    public struct Koordinat
    {
        public int x;
        public int y;

        public Koordinat(int px, int py)
        {
            x = px;
            y = py;
        }
    }

    public struct Daire
    {
        public Koordinat K;
        public int yaricap;

        public Daire(Koordinat baslangic, int yari)
        {
            K = baslangic;
            yaricap = yari;
        }
    }
    public struct Dikdortgen
    {
        public Koordinat K;
        public int yukseklik;
        public int genislik;

        public Dikdortgen(Koordinat koordinat, int yuksek, int genis)
        {
            K = koordinat;
            yukseklik = yuksek;
            genislik = genis;
        }

    }
    public class Hesap
    {

        public static void merkezKoordinatDaire(Daire daire)
        {
            Koordinat merkez;

            merkez.x = daire.K.x + daire.yaricap;

            merkez.y = daire.K.y - daire.yaricap;

            Console.WriteLine("Merkez koordinatları : " + merkez.x + "," + merkez.y);

        }

        public static void merkezKoordinatDikdortgen(Dikdortgen dikdortgen)
        {
            Koordinat merkez;

            merkez.x = dikdortgen.K.x + (dikdortgen.genislik / 2);

            merkez.y = dikdortgen.K.y - (dikdortgen.yukseklik / 2);

            Console.WriteLine("Merkez koordinatları : " + merkez.x + "," + merkez.y);
        }


        public static void cevreDaire(Daire daire)
        {
            int cevre;

            cevre = 2 * 3 * daire.yaricap;

            Console.WriteLine("Daire'nin çevresi : " + cevre);
        }

        public static void cevreDikdortgen(Dikdortgen dikdortgen)
        {
            int cevre;

            cevre = (dikdortgen.yukseklik + dikdortgen.genislik) * 2;

            Console.WriteLine("Dikdörtgenin çevresi : " + cevre);
        }


        public static void alanDaire(Daire daire)
        {
            int alan;

            alan = daire.yaricap * daire.yaricap * 3;

            Console.WriteLine("Daire'nin alanı : " + alan);
        }

        public static void alanDiktortgen(Dikdortgen dikdortgen)
        {
            int alan;

            alan = dikdortgen.genislik * dikdortgen.yukseklik;

            Console.WriteLine("Dikdörtgen'nin alanı : " + alan);
        }
    }
}

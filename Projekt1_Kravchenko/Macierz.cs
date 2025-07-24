using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Kravchenko
{
    class Macierz
    {
        private float[,] macierz;
        public Macierz (ushort liczbaWierczy, ushort liczbaKolumn)
        {
            macierz = new float[liczbaWierczy, liczbaKolumn];
        }

        public ushort LiczbaWierszy
        {
            get { return (ushort)macierz.GetLength(0);  }
        }
        public ushort LiczbaKolumn
        {
            get { return (ushort) macierz.GetLength(1); }
        }



        public float this[ushort NrWierza, ushort NrKolumny]
        {
            set { macierz[NrWierza, NrKolumny] = value; }
            get { return macierz[NrWierza, NrKolumny]; }
        }

        //+
        public static Macierz operator + (Macierz a, Macierz b)
        {
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {
                throw new ArgumentException("ERROR: wymiany macierzy nie spełniają warunki zgodności");
            }
            
            Macierz C = new Macierz(a.LiczbaWierszy, b.LiczbaKolumn);

            for (ushort i = 0; i < a.LiczbaWierszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = a.macierz[i, j] + b.macierz[i, j];
                }
            return C;
        }

        //-
        public static Macierz operator - (Macierz a, Macierz b)
        {
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {
                throw new ArgumentException("ERROR: wymiany macierzy nie spełniają warunki zgodności");
            }

            Macierz C = new Macierz(a.LiczbaWierszy, b.LiczbaKolumn);

            for (ushort i = 0; i < a.LiczbaWierszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = a.macierz[i, j] - b.macierz[i, j];
                }
            return C;
        }

        //*
        public static Macierz operator * (Macierz a, Macierz b)
        {
            if (a.LiczbaWierszy != b.LiczbaWierszy || a.LiczbaKolumn != b.LiczbaKolumn)
            {
                throw new ArgumentException("ERROR: wymiany macierzy nie spełniają warunki zgodności");
            }

            Macierz C = new Macierz(a.LiczbaWierszy, b.LiczbaKolumn);

            for (ushort i = 0; i < a.LiczbaWierszy; i++)
                for (ushort j = 0; j < a.LiczbaKolumn; j++)
                {
                    C.macierz[i, j] = 0.0F;
                    for (ushort k = 0; k < b.LiczbaWierszy; k++)
                    {
                        C.macierz[i, j] += a.macierz[i, k] * b.macierz[k, j];
                    }
                }
            return C;
        }
    }
}

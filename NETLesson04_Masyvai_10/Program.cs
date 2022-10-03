using System;

/* Sukurti 3x3 matricą.
 * Išvesti:1. visų matricos elementų sumą2.
 * kiekvienos eilutės elementų sumą3.
 * kiekvieno stulpelio elementų sumą. */

namespace NETLesson04_Masyvai_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] masyvas = {{11,12,13},
                              {21,22,23},
                              {31,32,33}};
            int[] eilutes = new int[3];
            int[] stulpeliai = new int[3];

            int suma = 0;

            for (int a = 0; a < masyvas.GetLength(0); a++)
            {
                for (int b = 0; b < masyvas.GetLength(1); b++)
                {
                    suma += masyvas[a, b];
                }
            }
            Console.WriteLine(suma);

            for (i = 0; i < 3; i++)
            {
                eilutes[i] = 0;
                for (j = 0; j < 3; j++)
                    eilutes[i] = eilutes[i] + masyvas[i, j];
            }

            for (i = 0; i < 3; i++)
            {
                stulpeliai[i] = 0;
                for (j = 0; j < 3; j++)
                    stulpeliai[i] = stulpeliai[i] + masyvas[j, i];
            }

            Console.Write("Eiluciu ir stulpeliu sumos :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write("{0}    ", masyvas[i,j]);
                Console.Write("{0}    ", eilutes[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < 3; j++)
            {
                Console.Write("{0}   ", stulpeliai[j]);
            }
            Console.Write("\n\n");
        }
    }
}

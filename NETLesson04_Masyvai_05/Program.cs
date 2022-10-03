using System;
using System.Collections;
using System.Collections.Immutable;
using System.Linq;

/* Sukurti 2 masyvus ir užpildyti atsitiktiniais skaičiais. 
 * Sujungti juos į vieną, surūšiuoti ir išvesti. */

namespace NETLesson04_Masyvai_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas1 = new int[5];
            int[] masyvas2 = new int[5];
            Random random = new Random();
            Console.Write("Sugeneruotas masyvas: ");
            for (int i = 0; i < masyvas1.Length; i++)
            {
                Console.Write($"{masyvas1[i] = random.Next(100)} ");  //isvedu savo randomini masyva
            }
            Console.WriteLine();
            Console.Write("Sugeneruotas masyvas: ");
            for (int i = 0; i < masyvas2.Length; i++)
            {
                Console.Write($"{masyvas2[i] = random.Next(100)} ");  //isvedu savo randomini masyva
            }

            int[] sujungtas = new int[masyvas1.Length + masyvas2.Length];

            masyvas1.CopyTo(sujungtas, 0);
            masyvas2.CopyTo(sujungtas, masyvas1.Length);
            Console.WriteLine();
            Console.Write("Sujungtas masyvas: ");
            for (int i = 0; i < sujungtas.Length; i++)
            {
                Console.Write($"{sujungtas[i]} ");  //isvedu savo sujungta masyva
            }
            Console.WriteLine();
            Console.Write("Sutvarkytas masyvas: ");
            Array.Sort(sujungtas);
            Array.ForEach<int>(sujungtas, n => Console.Write($"{n} "));

        }
    }
}

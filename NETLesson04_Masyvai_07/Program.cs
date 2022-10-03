using System;

/* Parašyti programą, kurioje ištrinamas bet kuris masyvo elementas. 
 * Pastaba –masyvas nukopijuojamas į naują masyvą BE pasirinkto elementoRezultatas parodomas. */

namespace NETLesson04_Masyvai_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[5];
            Random random = new Random();
            Console.Write("Sugeneruotas masyvas: ");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write($"{masyvas[i] = random.Next(100)} ");  //isvedu savo randomini masyva
            }
            Console.WriteLine();
            int pos = 2;

            for (int i = pos - 1; i < 4; i++)
            {
                masyvas[i] = masyvas[i + 1];
            }

            int[] atnaujintas = new int[4];
            Array.Copy(masyvas, 0, atnaujintas, 0, 4);
            Console.Write("Nukopijuotas masyvas: ");
            foreach (int res in atnaujintas)
            {
                Console.Write($" {res}");
            }
        }
    }
}

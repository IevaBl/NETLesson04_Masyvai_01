using System;
using System.Linq;

/* Užpildyti masyvą atsitiktiniais skaičiais ir parodyti kiek karų kartojasi kiekvienas elementas. */

namespace NETLesson04_Masyvai_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[10];
            Random random = new Random();
            Console.Write("Sugeneruotas masyvas: ");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write($"{masyvas[i] = random.Next(5)} ");  //isvedu savo randomini masyva
            }
            Console.WriteLine();

            foreach (int item in masyvas)
            {
                Console.Write($"Skaicius: {item.ToString()} " + "=>");
                int kartojasi = 0;
                for (int i = 0; i < masyvas.Length; ++i)
                {
                    if (masyvas[i] == item) ++kartojasi;
                }
                Console.WriteLine($" {kartojasi} kartus");
            }
        }
    }
}

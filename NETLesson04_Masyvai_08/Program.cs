using System;

/* Parodyti antra didžiausią ir antrą mažiausią elementą masyve. */

namespace NETLesson04_Masyvai_08
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
            Array.Sort(masyvas);
            Console.Write("Surusiuotas masyvas: ");
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write(masyvas[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Antras didziausias elementas yra : {masyvas[masyvas.Length - 2]}");
            Console.WriteLine($"Antras maziausias elementas yra : {masyvas[1]}");
        }
    }
}

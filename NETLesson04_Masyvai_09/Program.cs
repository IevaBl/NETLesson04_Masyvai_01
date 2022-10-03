using System;

/* Parašyti masyvo rūšiavimo algoritmą */

namespace NETLesson04_Masyvai_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[] { 1,6,3,2,8,7,4,5,9 };

            Array.Sort(masyvas);
            Console.WriteLine("Didejimo tvarka: ");
            foreach (int value in masyvas)
            {
                Console.Write(value + " ");
            }

            Array.Reverse(masyvas);
            Console.WriteLine("\n\nMazejimo tvarka: ");
            
            foreach (int value in masyvas)
            {
                Console.Write(value + " ");
            }
        }
    }
}

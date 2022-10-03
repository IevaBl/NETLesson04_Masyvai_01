using System;
using System.Linq;

/* Vartotojas įveda 5 skaičius, programa išveda jų sumą */

namespace NETLesson04_Masyvai_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkis skaicius:");
            int[] answer = new int[10];
            for (int i = 0; i < 5; i++)
            {
                answer[i] = Convert.ToInt32(Console.ReadLine());
            }
            var sum = answer.Sum();
            Console.WriteLine(sum);
        }
    }
}

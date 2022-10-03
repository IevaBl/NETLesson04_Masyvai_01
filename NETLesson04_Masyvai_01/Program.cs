using System;

/* Vartotojas įveda 5 skaičius, programa išveda juos atvirkštine tvarka */

namespace NETLesson04_Masyvai_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkis skaicius:");
            string[] answer = new string[10];
            for (int i = 0; i < 5; i++)
            {
                answer[i] = Console.ReadLine();
            }
            Console.WriteLine($"{answer[4]}, {answer[3]}, {answer[2]}, {answer[1]}, {answer[0]}");
        }
    }
}

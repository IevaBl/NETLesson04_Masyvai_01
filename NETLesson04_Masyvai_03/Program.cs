using System;

/* Vartotojas įveda 5 skaičius, programa juos išsaugo masyve, 
 * nukopijuoja į kitą (naują) masyvą ir parodo naujo masyvo turinį */

namespace NETLesson04_Masyvai_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkis skaicius:");
            int[] answer = new int[5];
            for (int i = 0; i < 5; i++)
            {
                answer[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] naujas = new int[5];
            
            Array.Copy(answer, 0, naujas, 0, 5);
            Console.WriteLine("Nukopijuotas masyvas");
            foreach (int res in naujas)
            {
                Console.Write($" {res}");
            }

        }
    }
}

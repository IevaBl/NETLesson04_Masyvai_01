using System;
using System.Linq;

/* Užpildyti masyvą atsitiktiniais skaičiais. 
 * Surasti ir parodyti didžiausią ir mažiausią elementą. 
 * Masyvą surūšiuoti ir išvesti. */

namespace NETLesson04_Masyvai_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            Random random = new Random();
            Console.Write("Sugeneruotas masyvas: ");
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write($"{skaiciai[i] = random.Next(100)} ");  //isvedu savo randomini masyva
            }
            Console.WriteLine();
            Console.WriteLine($"Didziausias masyvo skaicius => { skaiciai.Max()} ");
            Console.WriteLine($"Maziausias masyvo skaicius => {skaiciai.Min()}");
            

        }
    }
}

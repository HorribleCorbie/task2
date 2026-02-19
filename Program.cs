using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Известны оценки каждого из учеников класса. Посчитать количество пятерок, количество четверок, количество троек и количество двоек.

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] rating = new int[15];
            int five = 0, four = 0, three = 0, two = 0;
            for (int i = 0; i < rating.Length; i++)
            {
                rating[i] = rand.Next(2, 6);
                switch (rating[i])
                {
                    case 2: two++; break;
                    case 3: three++; break;
                    case 4: four++; break;
                    case 5: five++; break;
                }
            }
            string message = "Кол-во 5: " + five + "\nКол-во 4: " + four + "\nКол-во 3: " + three + "\nКол-во 2: " + two;
            Console.WriteLine(message);

        }
    }
}

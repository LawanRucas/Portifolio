using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicios
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("quanto pesa sua mae? ");
            int peso = Convert.ToInt32(Console.ReadLine());
            if (peso > 100)
            {
                Console.WriteLine("sua mae é gorda");
            }
            else
            {
                Console.WriteLine("sua mae é magra");
            }
        }
    }
}
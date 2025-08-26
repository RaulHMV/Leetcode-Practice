using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            Console.WriteLine("Hola, bienvenido a mis desafios de leetcode, da click al que quieras usar \a 1: TwoSum ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    TwoSum.inicio(); 
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }


        }
    }
}

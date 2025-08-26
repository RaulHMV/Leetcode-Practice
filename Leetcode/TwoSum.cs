using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class TwoSum
    {
        public double[] FindTwoSum(double[] numeros, double objetivo)
        {
            Dictionary<double, double> vistos = new Dictionary<double, double>();

            for (double i = 0; i < numeros.Length; i++)
            {
                double complemento = objetivo - numeros[(int)i];
                if (vistos.ContainsKey(complemento))
                {
                    return new double[] { vistos[complemento], i };
                }
                if (!vistos.ContainsKey(numeros[(int)i]))
                    vistos[numeros[(int)i]] = i;
            }

            return new double[0]; // nunca pasa según el problema
        }

        public static void inicio()
        {
            Console.WriteLine("ingrese la cantidad de numeros a añadir");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            double[] numeros1 = new double[(int)cantidad];
            Console.WriteLine("ingrese el numero objetivo");
            double objetivo1 = Convert.ToDouble(Console.ReadLine());
            for (double i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese el numero");
                numeros1[(int)i] = Convert.ToDouble(Console.ReadLine());
            }
            TwoSum twosum = new TwoSum();
            double[] resultado = twosum.FindTwoSum(numeros1, objetivo1);
            if (resultado.Length == 2)
            {
                Console.WriteLine($"Los índices son: {resultado[0]} y {resultado[1]}");
            }
            else if (resultado.Length == 0)
            {
                Console.WriteLine("No se encontraron dos números que sumen el objetivo.");
            }
            else if (resultado.Length >= 3)
            {
                Console.WriteLine("Hubo mas de dos indices que dieron la suma");
            }
            else
            {
                Console.WriteLine("error desconocido");
            }
        }
    }
}
    




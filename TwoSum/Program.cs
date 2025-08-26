using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        public double[] TwoSum(double[] numeros, double objetivo)
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
        static void Main(string[] args)
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
            Program program = new Program();
            double[] resultado = program.TwoSum(numeros1, objetivo1);
            if (resultado.Length == 2)
            {

                Console.WriteLine($"Los índices son: {resultado[0]} y {resultado[1]}");
            }
            else
            {
                Console.WriteLine($"ningun numero dio de suma {objetivo1}");
            }
        }
    }
}

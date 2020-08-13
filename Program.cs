using System;
using System.Diagnostics;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int filasMatrizA = 100;
            int columnaMatrizA = 90;
            int filasMatrizB = columnaMatrizA;
            int columnasMatrizB = 6;

            double[,] matrizA = Calculadora.CrearMatriz(filasMatrizA, columnaMatrizA);
            double[,] matrizB = Calculadora.CrearMatriz(filasMatrizB, columnasMatrizB);

            Calculadora calculadora = new Calculadora();
            Stopwatch stopWatch = new Stopwatch();
            Stopwatch.StartNew();
            double[,] matriz = calculadora.MultiplicarParalelo(matrizA, matrizB);
            Stopwatch.stop();
            var tecks = stopWatch.ElapsedTicks;
            Console.WriteLine("Se demoro {tecks}");


            Stopwatch stopWatch1 = new Stopwatch();

            stopWatch1.Start();
            double[,] matrizAxBPrima = calculadora.Multiplicar(matrizA, matrizB);
            stopWatch1.stop();
            tecks = stopWatch.ElapsedTicks;
            Console.WriteLine("Se demoro {tecks}");

            
            //Imprimirmatriz(matriz);
            //Console.WriteLine("\nPrima");
            //Imprimirmatriz(matrizAxBPrima);
        }

        private static void Imprimirmatriz(double[,] matrizAxB)
        {
            for (int i = 0; i < matrizAxB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizAxB.GetLength(1); j++)
                {
                    Console.Write(matrizAxB[i, j] + " ");
                }

            }
        }
    }
}

using System;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Calculadora
    {
        internal static double[,] CrearMatriz(int filasMatriz, int columnaMatriz)
        {
            double[,] matriz = new double[filasMatriz, columnaMatriz];

            var generador = new Random();

            for (int i = 0; i < filasMatriz; i++)
            {
                for (int j = 0; j < columnaMatriz; j++)
                {
                    matriz[i, j] = generador.Next(10,90);
                }
            }
            return matriz;
        }
        internal double[,] Multiplicar(double[,] matrizA, double[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizB.GetLength(1);
            double[,] matrizR = new double[filas,columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matrizA.GetLength(1);k++);
                    temp += matrizA[i, k] * matrizB[k, j];
                    matrizR[i, j] = temp;
                }
            }
            return matrizR;
        }

        internal double[,] MultiplicarParalelo(double[,] matrizA, double[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizB.GetLength(1);
            
            double[,] matrizR = new double[filas, columnas];
            //for (int i = 0; i < filas; i++)
                Parallel.For(0, filas, i =>
            {
                for (int j = 0; j < columnas; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matrizA.GetLength(1); k++) ;
                    temp += matrizA[i, k] * matrizB[k, j];
                    matrizR[i, j] = temp;
                }
            });
            return matrizR;
        }
    }
}
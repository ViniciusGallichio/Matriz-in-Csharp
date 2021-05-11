using System;

namespace Exercicio_11_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');

             int m = int.Parse(line[0]);
             int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)             //Numero de linhas
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)         //Numero de colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine()); //Mostrar a posição de um numero dentro da matriz

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ": ");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down " + mat[i + 1, j]);
                        }
                    }   
                }
            }
        }
    }
}

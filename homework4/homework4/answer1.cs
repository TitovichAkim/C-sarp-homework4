using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class answer1
    {
        static void Main (string[] args)
        {
            Random rand = new Random();
            int[,] matrix;
            for(; ; )
            {
                Console.Write("Введите количество строк в матрице... ");
                if(int.TryParse(Console.ReadLine(), out int xNunber))
                {
                    for(; ; )
                    {
                        Console.Write("Введите количество столбцов в матрице... ");
                        if(int.TryParse(Console.ReadLine(), out int yNunber))
                        {
                            matrix = new int[xNunber, yNunber];
                            int summ = 0;
                            for(int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for(int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] = rand.Next(0, 100);
                                    summ += matrix[i, j];
                                    Console.Write($"{matrix[i, j], 3} ");
                                }
                                Console.Write("\n");
                            }
                            Console.WriteLine($"Сумма элементов данной матрицы равна {summ}");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Необходимо ввести целое число!");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Необходимо ввести целое число!");
                    continue;
                }
            }
        }
    }
}

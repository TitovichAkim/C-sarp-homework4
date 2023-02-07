using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class answer2
    {
        static void Main (string[] args)
        {
            Random rand = new Random();
            int[][] matrixA;
            int[][] matrixB;
            int[][] matrixC;        // Для того, чтобы сохранить в памяти
                                    // заполнение слогаемых матриц, для суммы сделаю третью
                                    // Хотя можно было для хранения новых значений 
                                    // использовать любую из матриц A или B.
                                    // Это заняло бы меньше оперативной памяти (да и по реализации не стало бы сложнее) 
            for(; ; )
            {
                Console.Write("Введите количество строк в матрицах... ");
                if(int.TryParse(Console.ReadLine(), out int xNunber))
                {
                    for(; ; )
                    {
                        Console.Write("Введите количество столбцов в матрицах... ");
                        if(int.TryParse(Console.ReadLine(), out int yNunber))
                        {
                            matrixA = new int[xNunber][];
                            matrixB = new int[xNunber][];
                            matrixC = new int[xNunber][];
                            Console.WriteLine("Матрица А: ");
                            for(int i = 0; i < xNunber; i++)
                            {
                                matrixA[i] = new int[yNunber];
                                matrixB[i] = new int[yNunber];
                                matrixC[i] = new int[yNunber];
                                for(int j = 0; j < yNunber; j++)
                                {
                                    matrixA[i][j] = rand.Next(0, 100);
                                    matrixB[i][j] = rand.Next(0, 100);
                                    Console.Write($"{matrixA[i][j], 3} ");
                                }
                                Console.Write("\n");
                            }
                            Console.WriteLine("Матрица B: ");
                            foreach(int[] bb in matrixB)
                            {
                                foreach(int b in bb)
                                {
                                    Console.Write($"{b,3} ");
                                }
                                Console.Write("\n");
                            }
                            Console.ReadKey();
                            Console.WriteLine("Результирующая матрица С: ");
                            int summ = 0;
                            for(int i = 0; i <  matrixC.Length; i++)
                            {
                                for(int j = 0; j < matrixC[i].Length; j++)
                                {
                                    matrixC[i][j] = matrixA[i][j] + matrixB[i][j];
                                    summ += matrixC[i][j];
                                    Console.Write($"{matrixC[i][j], 3} ");
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

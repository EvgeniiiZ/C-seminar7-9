// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Clear();

// Console.Write("ВВедите количество строк массива: ");
// int rows=int.Parse(Console.ReadLine());

// Console.Write("ВВедите количество столбцов массива: ");
// int columns=int.Parse(Console.ReadLine());

// double[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// double[,] GetArray(int m, int n, int min, int max)
// {
//     double[,] result = new double[m, n];
//         for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(10);
            
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Clear();

// Console.Write("ВВедите количество строк в массиве: ");
// int rows =int.Parse(Console.ReadLine());
// Console.Write("ВВедите количество столбцов в массиве: ");
// int columns =int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElement(int[,] array)
// {
// Console.Write("ВВедите индекс строки массиве: ");
// int positionX =int.Parse(Console.ReadLine());
// Console.Write("ВВедите индекс столбца в массиве: ");
// int positionY =int.Parse(Console.ReadLine());
// if (positionX < array.GetLength(0) && positionY < array.GetLength(1))
// {
//     Console.WriteLine(array[positionX,positionY]);

// }
// else
// {
//    Console.WriteLine("такого элемента нет"); 
// }
// }
// FindElement(array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

// Console.Clear();

// Console.Write("ВВедите количество строк в массиве: ");
// int rows =int.Parse(Console.ReadLine());
// Console.Write("ВВедите количество столбцов в массиве: ");
// int columns =int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SredAr(array);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SredAr(int[,] array1)
// {
//     double sum = 0;
// for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         for (int i = 0; i < array1.GetLength(0); i++)
//         {
//             sum = sum + array1[i,j];
            
//         }
//         Console.Write($"{(sum / array1.GetLength(0)):f1} ");
//         sum = 0; 

//     }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Clear();

// Console.Write("ВВедите количество строк массива: ");
// int rows=int.Parse(Console.ReadLine());

// Console.Write("ВВедите количество столбцов массива: ");
// int columns=int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             for (int t=j+1; t<array.GetLength(1); t++)
//             {
//                 if (array[i,t]>array[i,j])
//                 {
//                     int temp = array[i,j];
//                     array[i,j]=array[i,t];
//                     array[i,t] = temp;
//                 }
//             }
//         }
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("ВВедите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("ВВедите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Строка с наименьщей суммой - {GetRowNumbers(array)}");


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowNumbers (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        minsum = minsum + array[0,i];
        
    }
    
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
                if (minsum > sum)
        {
            minsum = sum;
            row = 1;
        }
    }
    return row;
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Clear();

// Console.Write("ВВедите количество строк 1 массива: ");
// int rowsA=int.Parse(Console.ReadLine());

// Console.Write("ВВедите количество столбцов 1 массива: ");
// int columnsA=int.Parse(Console.ReadLine());

// Console.Write("ВВедите количество строк 2 массива: ");
// int rowsB=int.Parse(Console.ReadLine());

// Console.Write("ВВедите количество столбцов 2 массива: ");
// int columnsB=int.Parse(Console.ReadLine());

// if (columnsA != rowsB)
// {
//     Console.WriteLine("Такие матрицы нельзя перемножать");
//     return;
// }
// int[,] A = GetArray(rowsA, columnsA, 0, 10);
// int[,] B = GetArray(rowsB, columnsB, 0, 10);

// PrintArray(A);
// Console.WriteLine();

// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetP(A,B));

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] GetP(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC[i,j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }
//     }
//     return arrayC;
// }

// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Clear();
// Console.Write("ВВедите размеры массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int p = 10;
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//               for (int k = 0; k < result.GetLength(2); k++) 
//               {
//                                result[i,j,k]=p;
//                                p = p + 1;
//               }       
//         }
//     }
//     return result;
// }


// void PrintArray(int[,,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(2); k++)
//         {
//             Console.Write($"{inArray[i,j,k]} ({i},{j},{k}) ");
//         }
//         Console.WriteLine();
//         }
               
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// int[,] array = new int[4, 4]
// {
//     {01, 02, 03, 04},
//     {12, 13, 14, 05},
//     {11, 16, 15, 06},
//     {10, 09, 08, 07}
// };

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(array);

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ )
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (array[i,j] / 10 <= 0)
//             {
//                 Console.Write($" {array[i,j]} ");
//             }
//             else 
//             {
//                 Console.Write($"{array[i,j]} ");
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
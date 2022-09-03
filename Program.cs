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

Console.Clear();

Console.Write("ВВедите количество строк в массиве: ");
int rows =int.Parse(Console.ReadLine());
Console.Write("ВВедите количество столбцов в массиве: ");
int columns =int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SredAr(array);

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

void SredAr(int[,] array1)
{
    double sum = 0;
for (int j = 0; j < array1.GetLength(1); j++)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            sum = sum + array1[i,j];
            
        }
        Console.Write($"{(sum / array1.GetLength(0)):f1} ");
        sum = 0; 

    }
}


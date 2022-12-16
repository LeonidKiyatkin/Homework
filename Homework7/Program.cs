// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// void FillArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите количество строк");
// int Rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int Columns = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[Rows, Columns];

// FillArray(array);
// PrintArray(array);
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 15);
        }
    }
}

void NoNumber(int[,] matrix)
{
    Console.Write("Строка - ");
    int Rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец - ");
    int Colums = Convert.ToInt32(Console.ReadLine());
    if (Rows <= matrix.GetLength(0) && Colums <= matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента {Rows} строки и {Colums} столбца равно {matrix[Rows -1, Colums - 1]}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
NoNumber(array);

//---

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 15);
//         }
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// void AverageNumberByColums(int[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         double Summa = 0;
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             Summa += matrix [i,j];
//         }
//         Console.WriteLine($"Cреднее арифметическое элементов в {j+1} столбце равно =  {Summa / matrix.GetLength(0)}; ");
//     }
// }



// int[,] array = new int[3, 3];
// FillArray(array);
// PrintArray(array);
// AverageNumberByColums(array);

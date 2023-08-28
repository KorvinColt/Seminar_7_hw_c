// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;

double[,] matrix = new double[m, n];

Random random = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.NextDouble() * 20 - 10;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

int element = GetMatrixElement(matrix, rows, columns);

if (element != int.MinValue)
{
    Console.WriteLine($"Значение элемента на позиции ({rows}, {columns}): {element}");
}
else
{
    Console.WriteLine($"Элемент на позиции ({rows}, {columns}) не существует.");
}

int GetMatrixElement(int[,] matrix, int row, int col)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    if (row >= 0 && row < numRows && col >= 0 && col < numCols)
    {
        return matrix[row, col];
    }

    return int.MinValue;
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

double[] columnAverages = new double[matrix.GetLength(1)];

for (int col = 0; col < matrix.GetLength(1); col++)
{
    double columnSum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        columnSum += matrix[row, col];
    }

    columnAverages[col] = columnSum / matrix.GetLength(0);
}

Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int col = 0; col < matrix.GetLength(1); col++)
{
    Console.Write(columnAverages[col].ToString("F1"));
    if (col < matrix.GetLength(1) - 1)
    {
        Console.Write("; ");
    }
}

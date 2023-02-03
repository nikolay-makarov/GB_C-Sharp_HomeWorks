/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetCorrectNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.Write(message + " ");
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Введены некорректные данные. Повторите ввод.");
        }
    }
}

int[,] InitMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetColumnsMean(int[,] matrix)
{
    double sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum / matrix.GetLength(0)}; ");
    }
    Console.WriteLine();
}

int rows = GetCorrectNumber("Введите количество строк: ");
int columns = GetCorrectNumber("Введите количество столбцов: ");
int[,] randomMatrix = InitMatrix(rows, columns);
PrintMatrix(randomMatrix);
GetColumnsMean(randomMatrix);

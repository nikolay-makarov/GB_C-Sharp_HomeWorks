/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int GetCorrectNumber(string message)
{
    int correctNumber = 0;
    while (true)
    {
        Console.Write($"{message}: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber > 0)
        {
            return correctNumber;
        }
        else
        {
            Console.WriteLine("Введенные данные не корректны!");
        }
    }
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(10);
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
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[] array)
{
    int maxIndex;
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        maxIndex = i;
        for (int m = i; m < array.Length; m++)
        {
            if (array[m] > array[maxIndex])
                maxIndex = m;
        }
        temp = array[i];
        array[i] = array[maxIndex];
        array[maxIndex] = temp;
    }
}

int[,] SortMatrix(int[,] matrix)
{
    int[,] sortedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int[] sortedRow = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sortedRow[j] = matrix[i, j];
        }
        SortArray(sortedRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sortedMatrix[i, j] = sortedRow[j];
        }
    }
    return sortedMatrix;
}

int rows = GetCorrectNumber("Введите количество строк");
int columns = GetCorrectNumber("Введите количество столбцов");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(SortMatrix(matrix));

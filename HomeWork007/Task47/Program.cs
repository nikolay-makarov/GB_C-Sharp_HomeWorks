/*
Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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

double[,] InitMatrix(int row, int columns)
{
    double[,] matrix = new double[row, columns];
    const int Begin = -10, End = 10;
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (End - Begin) + Begin, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int lines = GetCorrectNumber("Введите количество строк матрицы: ");
int columns = GetCorrectNumber("Введите количество столбцов матрицы: ");
double[,] matrix = InitMatrix(lines, columns);
PrintMatrix(matrix);

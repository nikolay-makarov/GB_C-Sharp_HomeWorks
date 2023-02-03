/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/
int[,] InitRandomMatrix()
{
    Random rnd = new Random();
    int rows = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Распечатана матрица размером {matrix.GetLength(0)} * {matrix.GetLength(1)}.");
}

void ReturnMatrixElement(int[,] matrix)
{
    Console.Write("Введите индексы элемента массива (2 натуральных числа, через запятую): ");
    int rows = 0;
    int columns = 0;
    while (true)
    {
        string[] input = Console.ReadLine()!.Split(',');
        if (input.Length == 2)
        {
            bool isFirstCorrect = int.TryParse(input[0], out rows);
            bool isSecondCorrect = int.TryParse(input[1], out columns);
            if (isFirstCorrect && isSecondCorrect && rows > 0 && columns > 0)
                break;
            else
                Console.Write("Введенные данные не являются натуральными числами! Повторите ввод: ");
        }
        else
            Console.Write("Введено неверное количество данных! Повторите ввод: ");
    }
    if (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1))
        Console.WriteLine($"На позиции [{rows}, {columns}] находится элемент со значением {matrix[rows, columns]}");
    else
        Console.WriteLine("Такого элемента нет");
}

int[,] randomMatrix = InitRandomMatrix();
PrintMatrix(randomMatrix);
ReturnMatrixElement(randomMatrix);

/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int GetCorrectNumber(string message)
{
    int correctNumber = 0;
    while (true)
    {
        Console.Write($"{message}: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber > 0)
            return correctNumber;
        else
            Console.WriteLine("Введенные данные не корректны!");
    }
}

void RowOfNumbers(int n)
// Вариант решения без возвращаемого значения
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        RowOfNumbers(n - 1);
    }
    else
        Console.WriteLine(1);
}

string StringOfNumbers(int n)
// Вариант решения с возвращаемым значением
{
    if (n > 1)
        return $"{n}, " + StringOfNumbers(n - 1);
    else
        return 1.ToString();
}

int n = GetCorrectNumber("Введите целое положительное число");
RowOfNumbers(n);
Console.WriteLine(StringOfNumbers(n));

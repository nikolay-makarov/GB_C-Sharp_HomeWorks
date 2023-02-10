/* Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumOfNumericRange(int m, int n)
{
    if (m < n)
        return m + SumOfNumericRange(m + 1, n);
    else
        return n;
}

int m = GetCorrectNumber("Введите первое число");
int n = GetCorrectNumber("Введите второе число");
if (m > n)
    Console.WriteLine("Первое число должно быть меньше второго!");
else
    Console.WriteLine(SumOfNumericRange(m, n));

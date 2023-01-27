/* Задача 38:
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
 */
int getCorrectNumber()
{
    int correctNumber;
    while (true)
    {
        Console.Write("Введите число элементов массива: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber > 0)
            return correctNumber;
        else
            Console.WriteLine("Введены неверные данные!");
    }
}

decimal[] makeArray(int dimention)
{
    const int Begin = -100, End = 100;
    decimal[] array = new decimal[dimention];
    decimal number;
    Random random = new Random();
    for (int i = 0; i < dimention; i++)
    {
        number = (decimal)random.NextDouble() * (End - Begin) + Begin;
        array[i] = Math.Round(number, 2);
    }
    return array;
}

(decimal, decimal, decimal) MaxMinDifference(decimal[] array)
{
    decimal min = array[0];
    decimal max = array[0];
    foreach (var item in array)
    {
        if (min > item)
            min = item;
        else if (max < item)
            max = item;
    }
    return (max, min, max - min);
}

void printArray(decimal[] array)
{
    Console.Write("\n[");
    Console.Write(string.Join("  ", array));
    Console.Write(']');
}

Console.WriteLine("\nПрограмма формирует массив из случайных вещественных чисел от -100 до 100, ");
Console.WriteLine("округленных до 2-х знаков после запятой, возвращает значение максимального, ");
Console.WriteLine("минимального элемента массива и разницу между ними.\n");
var dimention = getCorrectNumber();
decimal[] myArray = makeArray(dimention);
var result = MaxMinDifference(myArray);
printArray(myArray);
Console.Write($" -> {result.Item3}\n");
Console.WriteLine($"Максимальный элемент массива: {result.Item1}, минимальный элемент массива: {result.Item2}.\n");

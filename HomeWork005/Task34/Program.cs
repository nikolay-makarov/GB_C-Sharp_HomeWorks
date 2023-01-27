/* Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */
int GetCorrectNumber()
{
    int correctNumber;
    while (true)
    {
        Console.Write("Введите число элементов массива: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber >= 0)
            return correctNumber;
        else
            Console.WriteLine("Введены неверные данные!");
    }
}

int[] MakeArray(int dimention)
{
    const int Begin = 100, End = 1000;
    int[] array = new int[dimention];
    Random random = new Random();
    for (int i = 0; i < dimention; i++)
        array[i] = random.Next(Begin, End);
    return array;
}

int EvenNumbersCount(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            counter++;
    }
    return counter;
}

void PrintArray(int[] array)
{
    Console.Write('[');
    Console.Write(string.Join(", ", array));
    Console.Write(']');
}

Console.WriteLine("Программа возвращает количество четных элементов массива.");
int dimention = GetCorrectNumber();
int[] myArray = MakeArray(dimention);
int count = EvenNumbersCount(myArray);
PrintArray(myArray);
Console.Write($" -> {count}\n");

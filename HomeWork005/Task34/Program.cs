/* Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */
int getCorrectNumber()
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

int[] makeArray(int dimention)
{
    const int Down = 100, Up = 1000;
    int[] array = new int[dimention];
    Random random = new Random();
    for (int i = 0; i < dimention; i++)
        array[i] = random.Next(Down, Up);
    return array;
}

int evenNumbersCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

void printArray(int[] array)
{
    Console.Write('[');
    Console.Write(string.Join(", ", array));
    Console.Write(']');
}

Console.WriteLine("Программа возвращает количество четных элементов массива.");
int dimention = getCorrectNumber();
int[] myArray = makeArray(dimention);
int count = evenNumbersCount(myArray);
printArray(myArray);
Console.Write($" -> {count}\n");

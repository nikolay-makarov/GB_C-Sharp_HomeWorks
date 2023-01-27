/* Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
    const int Begin = -99, End = 100;
    int[] array = new int[dimention];
    Random random = new Random();
    for (int i = 0; i < dimention; i++)
        array[i] = random.Next(Begin, End);
    return array;
}

int OddElementsSumm(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if(i % 2 == 1) result += array[i];
    return result;
}

void PrintArray(int[] array)
{
    Console.Write('[');
    Console.Write(string.Join(", ", array));
    Console.Write(']');
}

Console.WriteLine("Программа возвращает сумму элементов, стоящих на нечётных позициях.");
int dimention = GetCorrectNumber();
int[] myArray = MakeArray(dimention);
int result = OddElementsSumm(myArray);
PrintArray(myArray);
Console.Write($" -> {result}\n");

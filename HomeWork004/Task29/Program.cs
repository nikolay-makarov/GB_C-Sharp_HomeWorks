/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/
int[] getUserNumbers()
// 1-й вариант решения: Функция принимает от пользователя 8 чисел через запятую,
// проверяет корректность ввода,
// и возвращает массив, состоящий из введенных чисел
{
    string[] arr;
    int[] correctArray = new int[8];
    while (true)
    {
        Console.Write("Через запятую введите 8 целых чисел: ");
        arr = Console.ReadLine()!.Split(',');
        if (arr.Length == 8)
        {
            int value;
            bool allCorrect = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (int.TryParse(arr[i], out value))
                    correctArray[i] = value;
                else
                {
                    Console.WriteLine("Введенные данные не являются числами!");
                    allCorrect = false;
                    break;
                }
            }
            if(allCorrect)
                return correctArray;
        }
        else
            Console.WriteLine("Введено не 8 элементов!");
    }
}

int[] makeRandomNumbersArray()
// Второй вариант решения: Функция возвращает массив из случайных чисел от 1 до 100
{
    int[] array = new int[8];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomNumber.Next(1, 101);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]\n");
}

int[] userArray = getUserNumbers();
int[] randomArray = makeRandomNumbersArray();

Console.WriteLine($"---------------------------------");
Console.WriteLine($"Массив, введенный пользователем:");
printArray(userArray);
Console.WriteLine($"Массив из 8-ми случайных чисел от 1 до 100:");
printArray(randomArray);

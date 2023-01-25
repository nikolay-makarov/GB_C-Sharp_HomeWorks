/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int[] getCorrectNumbers()
{
    string[] arr;
    int a;
    int b;
    while (true)
    {
        Console.Write("Через запятую введите 2 целых числа. Второе число должно быть больше нуля: ");
        arr = Console.ReadLine().Split(',');
        if (int.TryParse(arr[0], out a) && int.TryParse(arr[1], out b) && b >= 1)
        {
            int[] array = { a, b };
            return array;
        }
        else
            Console.WriteLine("Введенные данные не соответствуют условию!");
    }
}

int[] numbers = getCorrectNumbers();

double result = 1;
for (int i = 0; i < numbers[1]; i++)
    result *= numbers[0];
Console.WriteLine($"{numbers[0]} в степени {numbers[1]} будет {result}");

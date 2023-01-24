/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int getCorrectNumber()
{
    int correctNumber;
    while(true)
    {
        Console.Write("Введите целое положительное число: ");
        if(int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber > 0)
            return correctNumber;
        else
            Console.WriteLine("Введены неверные данные!");
    }
}

int n = getCorrectNumber();

for (int i = 1; i < n; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.WriteLine(Math.Pow(n, 3));

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Console.Write("Введите трехзначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int GetSecondDigit(int number)
{
    return number % 100 / 10;
}

int number = GetNumber();
Console.WriteLine(GetSecondDigit(number));
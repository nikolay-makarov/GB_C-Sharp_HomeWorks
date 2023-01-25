/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int getCorrectNumber()
{
    int correctNumber;
    while(true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber))
            return correctNumber;
        else
            Console.WriteLine("Введенные данные не соответствуют условиям!");
    }
}

int sumOfDigits(int number)
{
    int result = 0;
    number = Math.Abs(number);
    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int myNumber = getCorrectNumber();
int answer = sumOfDigits(myNumber);
Console.WriteLine($"Сумма цифр числа {myNumber} будет {answer}");

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string getCorrectNumber()
{
    int inputNumber;
    string inputString;
    while(true)
    {
        Console.Write("Введите пятизначное число: ");
        inputString = Console.ReadLine();
        bool isCorrect = int.TryParse(inputString, out inputNumber);
        if(inputString.Length == 5 && inputNumber >= 0 && isCorrect)
            return inputString;
        else
            Console.WriteLine("Введенные данные не соответствуют условиям задачи!");
    }
}

string stringNumber = getCorrectNumber();
if(stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine($"Число {stringNumber} является палиндромом");
}
else
{
    Console.WriteLine($"Число {stringNumber} не является палиндромом");
}

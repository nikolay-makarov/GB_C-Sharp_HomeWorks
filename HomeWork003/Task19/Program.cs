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
    Console.WriteLine("Введите пятизначное число: ");
    int inputNumber = -1;
    string inputString;
    while(true)
    {   
        inputString = Console.ReadLine();
        bool isCorrect = int.TryParse(inputString, out inputNumber);
        // Проверка работает таким образом, что все целые пятизначные положительные числа, 
        // включая число 00000, рассматривается как соответствующее условиям задачи
        if(inputString.Length == 5 && inputNumber >= 0)
            break;
        else
            Console.WriteLine("Введенные данные не соответствуют условиям задачи!");
    }
    return inputString;
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
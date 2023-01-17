/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
char GetThirdDigit(string strNumber)
{
    return strNumber[2];
}

Console.Write("Введите число: ");

string strNumber = Console.ReadLine();

if(strNumber.Length >= 3)
{
    Console.WriteLine(GetThirdDigit(strNumber));
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int GetNumber()
{
    Console.Write("Введите цифру, обозначающую день недели: ");
    return Convert.ToInt32(Console.ReadLine());
}
string IsWeekend(int day)
{
    if(day >= 1 && day <= 5)
        return "Выходной? нет";
    else if(day == 6 || day == 7)
        return "Выходной? да";
    else
        return "Введены неверные данные!";
}

int weekDay = GetNumber();
string answer = IsWeekend(weekDay);
Console.WriteLine(answer);
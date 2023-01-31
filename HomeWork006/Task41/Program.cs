/*
Задача 41: Пользователь вводит с клавиатуры числа. Посчитайте,
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вводим через один Enter (разбиваем через Split())
*/
Console.WriteLine("Введите целые числа через запятую:");
string[] array = Console.ReadLine()!.Split(',');
int count = 0;
foreach (var item in array)
    if (int.Parse(item) > 0) count++;
Console.WriteLine($"Количество введенных чисел больше нуля: {count}");

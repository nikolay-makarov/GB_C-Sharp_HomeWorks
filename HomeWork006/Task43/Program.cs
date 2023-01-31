/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Write("Введите коэффициент b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine()!);
if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются!");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    Console.WriteLine($"Пересечение прямых находится в точке с координатами ({x}; {y})");
}

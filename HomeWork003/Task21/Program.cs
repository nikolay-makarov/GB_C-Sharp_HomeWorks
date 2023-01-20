/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
float getCorrectNumber(string coordinateName, string dotName)
{
    string inputNumber;
    bool isCorrect;
    float correctNumber;
    while (true)
    {
        Console.Write($"Введите координату {coordinateName} точки {dotName}: ");
        inputNumber = Console.ReadLine();
        isCorrect = float.TryParse(inputNumber, out correctNumber);
        if (isCorrect)
            return correctNumber;
        else
            Console.WriteLine("Должно быть введено число!");
    }
}

float ax = getCorrectNumber("x", "A");
float ay = getCorrectNumber("y", "A");
float az = getCorrectNumber("z", "A");
float bx = getCorrectNumber("x", "B");
float by = getCorrectNumber("y", "B");
float bz = getCorrectNumber("z", "B");

float result = (float)Math.Sqrt(
    Math.Pow(ax - bx, 2) +
    Math.Pow(ay - by, 2) +
    Math.Pow(az - bz, 2)
);
Console.Write($"Расстояние между точками А({ax}; {ay}; {az}) ");
Console.WriteLine($"и В({bx}; {by}; {bz}) равно {Math.Round(result, 2)}.");
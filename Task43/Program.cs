// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y = k1 * x + b1, y = k2 * x + b2
// y = 5x+2 y = 9x + 4
// y = 5x-2 = 9x
// -2 = 4x 
// [1] -[3] /[0] -[2]]




bool Fill_numbers(double[] numbers)
{
    Console.Write($"Введите число b1: ");
    numbers[0] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число k1: ");
    numbers[1] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число b2: ");
    numbers[2] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число k2: ");
    numbers[3] = double.Parse(Console.ReadLine());
    if (numbers[1] == numbers[3])
    {
        System.Console.WriteLine("Линии будут паралелльны, потому x и y не будет найден ");
        return false;
    }
    return true;
}


double x(double[] numbers)
{
    double x = (numbers[2] - numbers[0]) / (numbers[1] - numbers[3]);
    return x;
}


double y(double[] numbers, double x)
{
    double y = numbers[1] * x + numbers[0];
    return y;
}


void PrintResult(double x, double y)
{
    Console.Write($"({x} ; {y})");
}


void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


void Task43()
{
    int size = 4;
    double[] numbers = new double[size];

    if (Fill_numbers(numbers) == false)
    {
        return;
    }
    Console.Write($"Имеющиеся числа: ");
    PrintArray(numbers);
    Console.Write($"x: {x(numbers)} ");
    Console.Write($"y: {y(numbers, x(numbers))} ");
}


Task43();
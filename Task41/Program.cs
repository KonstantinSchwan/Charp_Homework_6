// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


void Fill_numbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число №{i + 1} : ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
}


void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


void PlusNumbers(int[] numbers)
{
    int plus = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            plus += 1;
        }
    }
    Console.WriteLine(plus);
}


void Task41()
{
    Console.Write($"Какое количество цыфер вы хотите ввести?: ");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];


    Fill_numbers(numbers);
    Console.Write($"Имеющиеся числа: ");
    PrintArray(numbers);
    Console.Write($"Количество чисел больше нуля: ");
    PlusNumbers(numbers);
}


Task41();
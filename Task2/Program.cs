// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите первое число ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Введите второе число ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

if (!isParsedM || !isParsedN || n > m || n == m)
{
    Console.Write("Ошибка!");
    return;
}

int SumBetweenNumbers(int number1, int number2)
{
    if (number1 > number2) return 0;
    return number1 + SumBetweenNumbers(++number1, number2);
}

Console.WriteLine($"Результат = {SumBetweenNumbers(n, m)}");
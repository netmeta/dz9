// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN || n <= 0)
{
    Console.Write("Ошибка!");
}

void PrintNumbersBetweenOne(int number)
{
    if (number < 1)
    {
        return;
    }
    Console.Write($"{number} ");
    PrintNumbersBetweenOne(number - 1);
}
PrintNumbersBetweenOne(n);
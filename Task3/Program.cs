// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.Clear();
Console.Write("Введите первое число (M): ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите второе число (N): ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка, не правильно введены числа для данной задачи!");
    return;
}

Console.WriteLine($"Результат = {AckermannFunc(m, n)}");

int AckermannFunc(int m, int n)
{
    if (m == 0) return ++n;

    if (m != 0 && n == 0) return AckermannFunc(m - 1, 1);

    if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));

    return AckermannFunc(m, n);
}
// Задача 4 *.Напишите программу, которая заполнит спирально массив 4 на 4.


Console.Clear();
Console.Write("Введите размер массива: ");
int parametr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] SpiralArray = new int[parametr, parametr];

CreateSquareSpiralArray(SpiralArray, parametr, 0, 1); 
Print2DArrayAddNull(SpiralArray);


void CreateSquareSpiralArray(int[,] array, int size, int startPos, int startValue) 
{

    if (startValue < array.GetLength(0) * array.GetLength(1))
    {
        int currentValue = startValue, row = startPos, column = startPos;

        for (column = startPos; column < size - 1; column++) array[row, column] = currentValue++;

        column = size - 1;

        for (row = startPos; row < size - 1; row++) array[row, column] = currentValue++;

        for (column = size - 1; column > startPos; column--) array[row, column] = currentValue++;

        for (row = size - 1; row > column; row--) array[row, column] = currentValue++;

        row++; column++;

        CreateSquareSpiralArray(SpiralArray, size - 1, startPos + 1, currentValue);
    }

    if (array.GetLength(0) % 2 != 0) array[(array.GetLength(0) - 1) / 2, (array.GetLength(1) - 1) / 2] = size *= size;
}


void Print2DArrayAddNull(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0");
                Console.Write($"{array[i, j]} ");
            }

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}
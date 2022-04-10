// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void MinSumRow(int[,] array)
{
    int[] rowSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        rowSum[i] = sum;
    }
    int minSum = rowSum[0], numMinRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        if (rowSum[i] < minSum)
        {
            minSum = rowSum[i];
            numMinRow = i;
        }
    Console.WriteLine($"минимальная сумма = {minSum}");
    Console.WriteLine($"минимальная строка = {numMinRow + 1}");
}



int[,] array = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
MinSumRow(array);



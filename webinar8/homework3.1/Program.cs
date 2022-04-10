// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] array1 = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();

int[,] array2 = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

if (array1.GetLength(0) == array2.GetLength(1))
{
    int[,] multArray = Multiplication(array1, array2);
    PrintArray(multArray);
}
else Console.WriteLine("Заданные матрицы не могут быть перемножены, введите матрицы так, чтобы количество строк первой матрицы ровнялось количеству столбцов второй");


// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] SwapRow(int[,] array)
{
   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[0, j];
            array[0, j] = array[array.GetLength(1) - 1, j];
            array[array.GetLength(1) - 1, j] = temp;
           
        }
      return array;
   
}


int[,] array = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(SwapRow(array));

// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// НЕВЕРНОЕ РЕШЕНИЕ, Т.К. не погуглил, что такое перемножить матрицы, решил как понял )))

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

void MultiplicationArray(int[,] array1, int[,] array2)
{
    int[,] multArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < multArray.GetLength(0); i++)
    {
        for (int j = 0; j < multArray.GetLength(1); j++)

        {
            Console.Write($"{array1[i, j] * array2[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] array1 = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();

int[,] array2 = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
if ((array1.GetLength(0) == array2.GetLength(0)) && (array1.GetLength(1) == array2.GetLength(1)))
{
    MultiplicationArray(array1, array2);
}
else Console.WriteLine("Заданные матрицы не равны друг другу по размеру, введите одинаковые по размеру матрицы");




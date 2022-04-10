// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int page, int row, int column)
{
    int[,,] array = new int[page, row, column];
    int element = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        element += i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            element += j;
            for (int k = 0; k < array.GetLength(2); k++)
            {
                element += k;
                array[i, j, k] = element;
            }
        }

    }
    return array;
}
void PrintArray(int[,,] array)

{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Стриница №: " + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" [{i}, {j}, {k}]: {array[i, j, k]}  ");
            }
            Console.WriteLine();
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

int[,,] array = FillArray(Prompt("Введите количество страниц "), Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array);
// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] FillArray(int page, int row, int column)
{
    int[,,] array = new int[page, row, column];


    bool Repeat;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Repeat = false;
                Random rnd = new Random();
                int value = rnd.Next(10, 100);
                array[i, j, k] = value;
                for (int l = 0; l < array.GetLength(0); l++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        for (int n = 0; n < array.GetLength(2); n++)
                        {
                            if (array[l, m, n] == value)
                            {
                                Repeat = true;
                                break;
                            }
                        }
                        if (Repeat)
                        {
                            array[i, j, k] = value;
                        }
                    }
                }
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
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


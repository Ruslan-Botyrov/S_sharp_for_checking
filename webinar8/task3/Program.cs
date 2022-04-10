// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

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


void Dictionary(int[,] array)

{
    int sumElement0 = 0;
    int sumElement1 = 0;
    int sumElement2 = 0;
    int sumElement3 = 0;
    int sumElement4 = 0;
    int sumElement5 = 0;
    int sumElement6 = 0;
    int sumElement7 = 0;
    int sumElement8 = 0;
    int sumElement9 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
            {
                sumElement0 = sumElement0+1;
            }
            if (array[i, j] == 1)
            {
                sumElement1 = sumElement1+1;
            }
            if (array[i, j] == 2)
            {
                sumElement2 = sumElement2+1;
            }
            if (array[i, j] == 3)
            {
                sumElement3 = sumElement3+1;
            }
            if (array[i, j] == 4)
            {
                sumElement4 = sumElement4+1;
            }
            if (array[i, j] == 5)
            {
                sumElement5 = sumElement5+1;
            }
            if (array[i, j] == 6)
            {
                sumElement6 = sumElement6+1;
            }
            if (array[i, j] == 7)
            {
                sumElement7 = sumElement7+1;
            }
            if (array[i, j] == 8)
            {
                sumElement8 = sumElement8+1;
            }
            if (array[i, j] == 9)
            {
                sumElement9 = sumElement9+1;
            }
        }

    }
    Console.WriteLine($"0 встречается {sumElement0} раз");
    Console.WriteLine($"1 встречается {sumElement1} раз");
    Console.WriteLine($"2 встречается {sumElement2} раз");
    Console.WriteLine($"3 встречается {sumElement3} раз");
    Console.WriteLine($"4 встречается {sumElement4} раз");
    Console.WriteLine($"5 встречается {sumElement5} раз");
    Console.WriteLine($"6 встречается {sumElement6} раз");
    Console.WriteLine($"7 встречается {sumElement7} раз");
    Console.WriteLine($"8 встречается {sumElement8} раз");
    Console.WriteLine($"9 встречается {sumElement9} раз");
}

int[,] array = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Dictionary(array);
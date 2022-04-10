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

int[] Dictionary(int[,] array)
{
    int[] freq = new int[10];
    foreach (int elem in array)
    {
        freq[elem]++;
    }
    return freq;
}

void PrintDictionary(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)

    {
        Console.WriteLine($"Число {i} встречается в массиве - {arr[i]} количество раз");
    }
    Console.WriteLine();
}



int[,] array = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int [] result = Dictionary(array);
PrintDictionary(result);
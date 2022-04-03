// Задача 4: Задайте двумерный массив. 
// Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Введенный элемент 2, результат: [1, 4]
//Введенный элемент 6, результат: такого элемента нет.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 100);
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


void SearchIndex(int[,] array)
{
    int element = Prompt("Введите элемент ");
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element == array[i, j])
            {
                count++;
                Console.Write($"[{i + 1}, {j + 1}]");
                return;
            }
        }
    }
    if (count == 0) Console.WriteLine("Такого элемента нет");
}

    int[,] array = FillArray(Prompt("Введите количество строк "), Prompt("Введите количество столбцов "));
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    SearchIndex(array);








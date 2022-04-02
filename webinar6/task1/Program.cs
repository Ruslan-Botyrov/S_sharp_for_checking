// Задача 1: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 5);
    }
    return answer;
}
void PrintArr(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count - 1; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine(Mas[Mas.Length - 1]);
}

void Reverse(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Swap2(arr, i, arr.Length - 1 - i);
    }
}

void Swap(int[] arr, int i, int j)
{
    (arr[i], arr[j]) = (arr[j], arr[i]);
}

void Swap2(int[] arr, int i, int j)
{
    int tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
}


var array = RandArray(5);
PrintArr(array);
Reverse(array);
PrintArr(array);
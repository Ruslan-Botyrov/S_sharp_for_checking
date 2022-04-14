// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void NaturalRow(int M, int N)
{
    if (M > N)
        return;
    Console.Write(M + " ,");
    NaturalRow(M + 1, N);
}



NaturalRow(Prompt("Введите M "), Prompt("Введите N "));
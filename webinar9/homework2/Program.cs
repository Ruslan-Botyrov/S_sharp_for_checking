// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int SumNaturalEvenNembers(int M, int N)
{
    if (M > N)
    return 0;
    return SumNaturalEvenNembers(M + 1, N) + M;
}

Console.WriteLine(SumNaturalEvenNembers(Prompt("Введите число M "), Prompt("Введите число N ")));
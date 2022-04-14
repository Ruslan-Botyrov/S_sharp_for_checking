// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12            45 -> 9

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int SumDigit(int N)
{
    if (N == 0) return 0;
    return SumDigit(N / 10) + N % 10;
}

Console.WriteLine(SumDigit(Prompt("Введите N ")));
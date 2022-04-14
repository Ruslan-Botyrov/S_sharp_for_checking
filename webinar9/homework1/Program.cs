// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void NaturalEvenNembers(int M, int N)
{
    if (M > N)
    return;
    if(M%2!=0){M+=1;}
    
    Console.Write(M + " ,");
    NaturalEvenNembers(M + 2, N);
}

NaturalEvenNembers(Prompt("Введите M "), Prompt("Введите N "));

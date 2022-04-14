// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int Power(int A, int B)
{
if(B==0) return 1;
return Power(A, B-1) * A;
}

Console.WriteLine(Power(Prompt("Введите число А "),Prompt("Введите число B ")));
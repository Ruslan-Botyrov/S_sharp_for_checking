// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int x = Prompt("Сколько числе хотите ввести? ");
int count = 0;

for(int i =1; i<=x; i++)
{
    Console.WriteLine($"Введите число {i}");
    int n = int.Parse(Console.ReadLine());
    if (n>0) count++;
}

Console.WriteLine($"Количество чисел больше нуля = {count}");


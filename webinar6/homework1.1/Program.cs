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
int i =1;


while (i<=x)
{
Console.WriteLine($"Введите число {i}");
int n = int.Parse(Console.ReadLine());
if (n>0) count++;i++;
}
Console.WriteLine($"Количество чисел больше нуля = {count}");
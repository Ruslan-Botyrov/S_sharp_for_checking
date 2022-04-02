// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int decimalNumber = Prompt("Введите десятичное число ");
int ostatok = 0;
int i = 0;
int[] binarNumber = new int[10];
// Нужно делить число на 2 и остаток от деления записывать в массив

while (decimalNumber >= 1)
{
    ostatok = decimalNumber % 2;
    decimalNumber = decimalNumber / 2;
    binarNumber[i] = ostatok;
    i++;
}
Console.Write("Введенное число в двоичной системе ");
for (int j = i - 1; j >= 0; j--)
{
    
    Console.Write(binarNumber[j]);
}


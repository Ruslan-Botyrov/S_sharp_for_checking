// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 7 -> 0 1 1 2 3 5 8
// каждое последующее число равно сумме двух предыдущих чисел

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int n = Prompt("Введите, сколько чисел фибоначи вывести? ");
int Fibonacchi1 = 0;
int Fibonacchi2 = 1;
int FibonacchiN = 0;
int i =0;
while (i<n-2){
FibonacchiN = Fibonacchi1 + Fibonacchi2;
Fibonacchi1 = Fibonacchi2;
Fibonacchi2 = FibonacchiN; i++;
}
Console.WriteLine(FibonacchiN);
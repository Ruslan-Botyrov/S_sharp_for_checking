// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int first = Prompt("Введите первое число ");
int second = Prompt("Введите второе число ");
int third = Prompt("Введите третье число ");

if (first + second >= third)
{
    {
        if (second + third >= first)
        {
            if (first + third >= second) ;
        }
    }
    Console.WriteLine("Треугольник существует");
}
else Console.WriteLine("Треугольник не существует");
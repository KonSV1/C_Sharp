// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write($" Введите число M более 1  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($" Введите число N более 1  ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < m) (m, n) = (n, m);
Console.Write($"M = {m}  [");
Print();
Console.Write($"]   N = {n}");

void Print()
{
    if (m <= n)
    {
        Console.Write($" {m} ");
        m++;
        Print();
    }
}

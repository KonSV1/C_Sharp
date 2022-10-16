// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Console.Clear();
Console.Write($" Введите положительное число  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($" Введите еще одно положительное число  ");
int n = Convert.ToInt32(Console.ReadLine());
if ((m < 0) || (n < 0))
{
    Console.Write("Одно или оба числа отрицательные. Попробуй еще раз");
}
else
{
    if (n < m)
    {
        (m, n) = (n, m);
    }
    Console.Write($"M = {m}; N = {n} -> ");
    Console.Write(Print(m));


    int Print(int arg)
    {
        if (arg <= n) return arg + Print(arg + 1);
        return 0;
    }
}
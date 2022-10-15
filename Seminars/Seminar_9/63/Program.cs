// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.Write($" Введите положительное число более 1  ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
Print();



void Print()
{
    if (m <= n)
    {
        Console.Write($" {m}");
        m++;
        Print();
    }
}

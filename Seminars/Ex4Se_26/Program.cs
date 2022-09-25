// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Floor(Math.Log10(n) + 1));
int i1 = 0;
int i = n;
while (i > 0)
{
   i = i / 10;
   i1++;
}
Console.WriteLine($"{n} -> {i1}");
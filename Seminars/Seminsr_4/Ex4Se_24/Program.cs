// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int S = 0;
for(int i = 1; i <= N; i++)
{
    S = S + i;
}
Console.Write($"{N} -> {S}");
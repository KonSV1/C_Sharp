// Задача 10.
//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.Write("Введите трехзначное число  ");
int num = Convert.ToInt32(Console.ReadLine());
if((num > 99) & (num < 1000))
{
    int num1 = (num % 100) / 10;
    Console.Write($"{num} -> {num1}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным. Попробуй еще раз");
}


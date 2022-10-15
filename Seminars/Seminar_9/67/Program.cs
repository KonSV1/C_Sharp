// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n = Math.Abs(n);
Console.WriteLine(SumNum(n));




int SumNum(int n)
{
    int s = 0;
    if (n / 10 > 0)
        return s + n % 10 + SumNum(n / 10);
    else
        return n % 10;
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
double r = (Math.Floor(Math.Log10(num) + 1));   // Определяем количество разрядов в числе
int p;                                          // Вводим переменую для взятия остатка от / на 10
int num1 = num;                                 // надо сохранинить начальное значение num для этого вводим num1
int sum = 0;
for(int i = 0; i < r; i++)
{
    p = num1 % 10;
    num1 = num1 / 10;
    sum = sum +p;
}
Console.WriteLine($"{num} -> {sum}");
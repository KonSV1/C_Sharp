// Написать программу запроса 2-х чисел
// и проверить не является ли первое число квадратом второго

Console.Clear();
Console.Write("Введите число 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num2 * num2;
if(res == num1)
{
    Console.WriteLine($"число {num1}: является квадратом числа {num2}");
}
else
Console.WriteLine($"число {num1}:  не является квадратом числа {num2}");
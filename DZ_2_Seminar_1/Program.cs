// Написать программу запроса 2-х чисел
// и вывода на экран какое больше, а какое меньше

Console.Clear();
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) Console.WriteLine($"число {num1} больше числа {num2}");
else
{
    Console.WriteLine($"число {num1} меньше числа {num2}");
}
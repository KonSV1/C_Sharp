// Написать программу запроса числа и вывода на экран является ли оно четным или нет.

Console.Clear();
Console.Write("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0) Console.WriteLine($"Число {num} является четным");
else
{
    Console.WriteLine($"Число {num} не является четным");
}

// Написать программу запроса 3-х чисел
// и вывода на экран максимального из них.

Console.Clear();
Console.Write("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0) Console.WriteLine($"Число {num} является четным");
else
{
    Console.WriteLine($"Число {num} не является четным");
}
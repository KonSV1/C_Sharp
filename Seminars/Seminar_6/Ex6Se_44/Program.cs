//  **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int[n];
Console.Write("Введите первое число ряда ");
arrey [0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ряда ");
arrey[1] = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i < n; i++)
{
    arrey[i] = arrey[i-2] + arrey[i-1];
}
PrintArrey();


void PrintArrey()
{
    Console.Write($"Если N  = {n} -> ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
}
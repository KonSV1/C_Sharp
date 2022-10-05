// Задача 32.
//Напишите программу замена элементов массива:
//положительные заментиь на соответсвующиме отрицательные и наоборот.
Console.Clear();
int n = new Random().Next(5, 10);
int[] arrey = new int[n];
Console.Write($"[");
for(int i = 0; i < n-1; i++)
{
    arrey[i] = new Random().Next(-9, 10);
    Console.Write($"{arrey[i]}, ");
}
 Console.Write($"{arrey[n-1]}]");
NegativeArrey();


void NegativeArrey() // Метод замены и вывода на экран
{
    Console.Write($"  ->  [");
    for(int i = 0; i < n-1; i++)
    {
        arrey[i] = arrey[i] * -1;
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write($"{arrey[n-1]}]");
}
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] arrey = new int[8];
for(int i = 0; i < 7; i++)
{
   arrey[i] = new Random().Next(0, 100);
   Console.Write($"{arrey[i]}, ");
}
arrey[7] = new Random().Next(0, 100);
Console.Write($"{arrey[7]}");
Console.Write(" -> [");
for(int i = 0; i < 7; i++)
{
   Console.Write($"{arrey[i]}, ");
}
Console.WriteLine($"{arrey[7]}]");

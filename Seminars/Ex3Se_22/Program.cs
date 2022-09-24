//Задача 22: Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int[N];
Console.Write($"{N} -> ");
for(int i = 0; i < N; i++)
{
     arrey[i] = i+1;
     int sqw = Convert.ToInt32(Math.Pow(arrey[i], 2));
     Console.Write($"{sqw}, ");
}

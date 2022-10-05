// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int N1 = Math.Abs(N);
int[] arrey = new int[N1];
Console.Write($"{N} -> ");
int i1 = 0;
for(int i = 0; i < N1; i++)
{
    if(N > 0)
    {
        arrey[i] = i+1;
        int Tr = Convert.ToInt32(Math.Pow(arrey[i], 3));
        Console.Write($"{Tr}, ");
    }
    else
    {
        arrey[i] = i1-1;
        i1--;
        int Tr = Convert.ToInt32(Math.Pow(arrey[i], 3));
        Console.Write($"{Tr}, ");   
    }
}

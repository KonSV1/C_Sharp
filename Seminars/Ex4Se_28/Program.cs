// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int N1 = Math.Abs(N);
int[] arrey = new int[N1];
//Console.Write($"{N} -> ");
int i1 = 0;
int Tr = 1;
for(int i = 0; i < N1; i++)
{
    if(N > 0)
    {
        arrey[i] = i+1;
        Tr = Tr * arrey[i];
    }
    else
    {
        arrey[i] = i1-1;
        i1--;
        Tr = Tr * arrey[i];
    }
}
Console.WriteLine($"{N} -> {Tr}");
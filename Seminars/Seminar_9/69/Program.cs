// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.Write($" Введите число A  ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($" Введите положительное число B  ");
int deg = Convert.ToInt32(Console.ReadLine());
Console.Write(Degree(deg));


int Degree(int n)
{
    if (n >0)
    {
        return num * (Degree(n-1));
    }
    return 1;
}



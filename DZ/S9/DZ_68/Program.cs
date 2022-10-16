// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write($" Введите первое число функци Аккермана  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($" Введите второе число функци Аккермана  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {m}, n = {n} -> A(m, n) = {Akkerman(m,n)}");


int Akkerman(int arg1, int arg2)
{
    if (arg1 == 0) return arg2 + 1;
    else
    {
        if ((arg1 > 0) && (arg2 == 0)) return Akkerman(arg1 - 1, 1);
        else
        {
            return Akkerman(arg1 - 1, Akkerman(arg1, arg2 - 1));
        }
    }
}
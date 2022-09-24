//17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите координату Х ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());
if ((x == 0)||(y == 0)) Console.WriteLine("Одна из координат равна 0 ");
{
    if((x > 0) & (y > 0)) Console.WriteLine("Точка находится в первой четверти");
    if((x < 0) & (y > 0)) Console.WriteLine("Точка находится во второй четверти");
    if((x < 0) & (y < 0)) Console.WriteLine("Точка находится в третей четверти");
    if((x > 0) & (y < 0)) Console.WriteLine("Точка находится в четвертой четверти");
}
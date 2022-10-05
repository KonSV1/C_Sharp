//Задача 21.
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координату Х точки А ");
double X = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А ");
double Y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А ");
double Z = Convert.ToDouble(Console.ReadLine());
//Console.Clear();
Console.WriteLine("Введите координату Х точки B ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B ");
double Z1 = Convert.ToDouble(Console.ReadLine());
double S = Math.Round(Math.Sqrt(Math.Pow((X1 - X), 2) + Math.Pow((Y1 - Y), 2) + Math.Pow((Z1 - Z), 2)),2);
Console.Write($"А ({X}, {Y}, {Z}); B ({X1}, {Y1}, {Z1}) -> {S}");
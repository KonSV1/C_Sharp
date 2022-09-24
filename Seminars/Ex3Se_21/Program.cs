// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координату х для первой точки ");
int X = Convert.ToInt32(Console.ReadLine());
//X = Math.Abs(X);
Console.Write("Введите координату y для первой точки ");
int Y = Convert.ToInt32(Console.ReadLine());
//Y = Math.Abs(Y);
Console.Write("Введите координату х для второй точки ");
int X1 = Convert.ToInt32(Console.ReadLine());;
//X1 = Math.Abs(X1);
Console.Write("Введите координату y для второй точки ");
int Y1 = Convert.ToInt32(Console.ReadLine());
//Y1 = Math.Abs(Y1);
double C = Math.Round(Math.Sqrt((Math.Pow((X1-X), 2) + Math.Pow((Y1-Y), 2))), 2);
Console.WriteLine(C);
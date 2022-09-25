// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, 
//общую точку или «не пересекаются».

Console.Clear();
Console.WriteLine("Введите координату Х1 отрезка 1 ");
Console.Write("Х1 -> ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2 отрезка 1 ");
Console.Write("Х2 -> ");
int X2 = Convert.ToInt32(Console.ReadLine());
if(X2<X1)
{
    Console.WriteLine("Точка X2 не может быть меньше точки X1. Попробуй еще раз.");
}
else
{
    Console.WriteLine("Введите координату X3 отрезка 2 ");
    Console.Write("Х3 -> ");
    int X3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Х4 отрезка 2 ");
    Console.Write("Х4 -> ");
    int X4 = Convert.ToInt32(Console.ReadLine());
    if(X4<X3)
    {
        Console.WriteLine("Точка X4 не может быть меньше точки X3. Попробуй еще раз.");
    }
    else
    {
        if ((X1>X4) || (X3>X2))
        {
            Console.WriteLine("Не пересекаются");
        }
        else
        {
            if ((X2==X3) || (X1==X4))
            {
                if (X2==X3)Console.Write($"Общаа точка {X2}");
                else
                {
                 Console.Write($"Общаа точка {X1}");
                }
            }
            else
            {
            if((X1<X3) & (X2>X3) & (X2<X4))Console.Write($"Граница пересечения отрезков ({X3}; {X2})");
            if((X3<X1) & (X4>X1) & (X4<X2))Console.Write($"Граница пересечения отрезков ({X1}; {X4})");
            if((X2>X4) & (X3>X1))Console.Write($"Граница пересечения отрезков ({X3}; {X4}). Отрезок 1 полностью включает в себя отрезок 2");
            if((X1>X3) & (X2<X4))Console.Write($"Граница пересечения отрезков ({X1}; {X2}). Отрезок 2 полностью включает в себя отрезок 1");   
            }
            
        }
    }
}


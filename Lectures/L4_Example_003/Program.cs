// Рекурсии

// Вычисление факториала
// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n* Factorial(n-1);
// }
// for(int i = 1; i<30; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");
//}

// Числа Фибоначчи
//f(1) = 1
//f(2) = 1
//f(3) = 2
//f(4) = 3
//f(5) = 5
//f(n) = f(n-1) + f(n-2)

 int Fibonacci(int n)
 {
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
 }

for (int i = 1; i < 60; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
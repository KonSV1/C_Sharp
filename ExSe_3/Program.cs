// Определить день недели по циыре от 1 до 7

Console.Clear();
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int numOtr = num * -1;
int count = numOtr;

while(count <= num)
{
    Console.Write($"{count}, ");
    count +=1;
}
// Задача 31.
//Задайте массив из 12-ти элементов, заполненный  случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

int[] arrey = new int[12];          //создаем массив из 12-ти элементов
int sum = 0; 
int sumn = 0;
void FillArrey()        // Метод заполнения массива ПСЧ от -9 до 9
{
   for(int i = 0; i < 12; i++)
   arrey[i] = new Random().Next(-9, 10);
}
void PrintArrey()       // метод вывода на экран данного массива
{
    for(int i = 0; i < 12; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine();
}
void SumPositive()      // метод считающий сумму положительных чисел
{
    for(int i = 0; i < 12; i++)
    {
        if(arrey[i] > 0) sum = sum +arrey[i];
    }
}
void SumNegative()      // метод считающий сумму отрицательных чисел
{
    for(int i = 0; i < 12; i++)
    {
        if(arrey[i] < 0) sumn = sumn +arrey[i];
    }
}
FillArrey();
PrintArrey();
SumPositive();
Console.WriteLine($"Сумма положительных чисел массива = {sum}.");
SumNegative();
Console.WriteLine($"Сумма отрицательных чисел массива = {sumn}.");




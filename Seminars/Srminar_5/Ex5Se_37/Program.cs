// Найдите произведение пар чисел в одномерном массиве.
// Парой счититаем первый и последний элемент, второй и предпоследний и т.п. 
// Результат записать в новый массив**
//     [1,2,3,4,5] → [5, 8, 3]
//     [6, 7, 3, 6] → [36, 21]

Console.Clear();
int n = new Random().Next(5,10);
int[] arrey = new int[n];
int n1 = n / 2;
if( n%2 > 0) n1 = n1 + 1;
int[] arrey1 = new int[n1];
FillArrey();
ComboRec();
PrintResult();



void FillArrey()    // Метод заполенения массива емкостью (n) элементов ПСЧ [0, 9]
{
    for(int i = 0; i < n; i++)
    {
        arrey[i] = new Random().Next(0, 10);
    }
}

void ComboRec()      // метод перемножения пар чисел и записи результата в новый массив
{
    if (n %2 == 0)
    {
        for(int i = 0; i < n/2; i++)
        {
            arrey1[i] = arrey[i] * arrey[n-1-i];
        }
    }
    else
    {
       for(int i = 0; i < n1-1; i++)
        {
            arrey1[i] = arrey[i] * arrey[n-1-i];
        }
        arrey1[n1-1] = arrey[n1-1];
    }
}

void PrintResult()  // Метод вывода результата на экран
{
    Console.Write($"[ ");
    for(int i = 0; i < n-1; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write($"{arrey[n-1]}] -> [");
    for(int j = 0; j < n1-1; j++)
    {
        Console.Write($"{arrey1[j]}, ");
    }
    Console.Write($"{arrey1[n1-1]}]");
}
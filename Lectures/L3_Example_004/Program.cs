// Упорядочить массив [1, 5, 7, 2, 9, 3, 4, 8, 6, 3]

int[] arr = {1, 5, 7, 2, 9, 3, 4, 8, 6, 3};
void PrintArrey(int[] arrey)            // метод для вывода элементов массива на экран
{
    int count = arrey.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] arrey)         //метод сортировки
{
    for (int i =0; i < arrey.Length - 1; i++)       //Поиск минимального значения (позиции с мин значением)
    {
        int minPos = i;
        for(int j = i + 1; j < arrey.Length; j++)   // Сам цикл поиска мин значения
        {
            if(arrey[j] < arrey[minPos]) minPos = j; //Присвоение значению minPos 
        }
       //замена позиций
        int temp = arrey[i];                        // присвоение временой переменной минимального значения
        arrey[i] = arrey[minPos];                   // присвоение текущей позиции миннимального значения
        arrey[minPos] = temp;                       // Присвоение найденной минимальной позиции значения, замененного на минимальное
    }
}
PrintArrey(arr);
SelectionSort(arr);
PrintArrey(arr);

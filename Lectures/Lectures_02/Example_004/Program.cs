// Создание массива и заполнение его псевдослучайными
//числами с помощью методов и поиск элемента по значению "find"

Console.Clear();
void FillArrey(int [] collection)    //Void метод без возвращения переменных (используется без return) 
{
    int lenght = collection.Length;  //определяем переменную путем получения размера массива
    int index = 0; 
    while(index < lenght) // цикл заполнения массива
    {
        collection[index] = new Random().Next(1, 10); //помещаем псевдослучайное число в масив на место index
        index++; //index = index + 1
    }
}

void PrintArrey(int [] col)
{
    int count = col.Length; //определяем переменную путем получения размера массива
    int position = 0;
    //int position = -1;
    while(position < count)    // цикл заполнения массива
    {
        Console.WriteLine(col[position]);  //выводим на экран элементы массива
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int [] arrey = new int [10]; // Создать массив емкостью 10 элементов
FillArrey(arrey);
PrintArrey(arrey);
Console.WriteLine();
int pos = IndexOf(arrey, 4);
Console.WriteLine(pos);
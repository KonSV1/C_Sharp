//1 Вид методов

void Metod1()                               // Создание метода
{
    Console.WriteLine(" Автор .....");      // Тело метода
}

Metod1();                                   // Вызов метода в программе


//2 Вид методов

void Metod2(string msg)                 // Создаем метод с одним аргументом
{
    Console.WriteLine(msg);             // Тело метода 
}

Metod2("Текст сообщения");              // Вызов метода


//Метод 2 с несколькими переменными
void Metod21(string msg, int count)     // Создаем метот с 2-я аргументами
{
    int i =0;                           // Тело метода (21 - 28 строки) 
    while(i < count)
    {
        Console.WriteLine(msg);         // Выводит сообщение несколько раз
        i++;
    }
}

Metod21("Text", 4);                     // Вызов метода (сово "Текст" вывести 4 раза)

Metod21(count: 6, msg: "Test");           // Еще один способ вызова Метода с применением именованных аргументов
                                            // в данном случае аргументы в вызовые можно располагать в произвольном порядке  






// 3 Вид Методов

int Metod3()                                // Создаем метод                          
{
    return DateTime.Now.Year;               // возвращение (return) значению метода текущего года
                                        
}
    // Вызов данного метода немного отличается от первых двух
int date = Metod3();                        // Присвоение переменной data  значения вычисляемого в методе (текущего года)                    
Console.WriteLine(date);                    // Вывод на экран





// 4 Вид методов

string Metod4(int count, string c)          // Создаем метод
{
    int i = 0;                              // Тело метода (строки 55 - 64)
    string result = string.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;                          // возвращение (return) значению метода текущего года     
}
// Вызов данного метода немного отличается от первых двух
  string res = Metod4(10, "qwert ");        // Присвоение переменной res значения метода определенное аргументами (количесво и текст)
  Console.WriteLine(res);                   // Вывод на экран






  
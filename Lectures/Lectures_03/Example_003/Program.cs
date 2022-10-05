//Заментить пробелы в тексте нижним подчеркиванием
// строчные буквы"к" заменить на прописные буквы "К", а Прописные "С" на строчные"с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежли бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + " Вы так красноречивы. Вы дадите мне чаю?";

// По сути строка это массив
// string s ="qwert"
//            01234
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;           // result =""  т.е. пустая строка (аналогично присвоение новой переменной значения "0")

    int  l = text.Length;
    for(int i =0; i < l; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result +$"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
//newText = Replace(newText, 'С', 'с');           //Прописные С в тексте не встречаются, так что бесполезно
//Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');           //Заменим "с" на "С"
Console.WriteLine(newText);
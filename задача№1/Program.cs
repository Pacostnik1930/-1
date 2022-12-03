//Дан текст.В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",а большие "С" заменить
// маленькими"с".

string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов,"
            + "а также будем использовать их на практике."
            + "И познакомимся с новыми языковыми конструкциями, в частности, циклом.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";

        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text,'С', 'с');
Console.WriteLine(newText);

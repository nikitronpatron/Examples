// Работа с текстом
// Дан тескт
// нужно заменить пробелы черточками
// маленькие "к" заменить большими "К"
// большие "С" заменить маленькими "С"

string txt = "Кончаю! Страшно перечесть... "
    + "Стыдом и страхом замираю... "
    + "Но мне порукой ваша честь, "
    + "И смело ей себя вверяю... ";

    //string s = "qwerty"
    //            012345
    //s[3] / r

    string Replace(string text, char oldValue, char newValue)
    {
        string result = String.Empty;// инициализация пустой строки
        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            if(text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";   
        }
        return result;
    }

    string newText = Replace(txt, ' ', '-');
    Console.WriteLine(newText);
    newText = Replace(newText, 'к', 'К');
    Console.WriteLine(newText);
    newText = Replace(newText, 'С', 'с');
    Console.WriteLine(newText);
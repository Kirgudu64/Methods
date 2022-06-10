//
//  Методы
//
//  Практическая работа
//
//  Цель: Закрепить знания по использованию методов
//


/// <summary>
/// Метод, ползволяющий вывести заголовок модуля в консоль
/// </summary>
/// <param name="Text">Текст заголовка</param>
static void Heading(string Text)
{
    Console.Clear();
    Console.WriteLine($"\n\t{Text}");
    Console.Write("\n\nВведите фразу: ");
}

/// <summary>
/// Метод, позволяющий разделить фразу на отдельные слова
/// Возвращает массив из отдельных слов фразы
/// </summary>
/// <param name="Phrase">Фраза для деления на слова</param>
static string[] SplitString(string Phrase)
{
    //string[] arrayWords = new string[];
    string[] arrayWords = Phrase.Split(' ','.',',');
    return arrayWords;
}

/// <summary>
/// Метод, позволяющий вывести в консоль массив слов (каждое слово с новой строки)
/// </summary>
/// <param name="Words">Массив слов</param>
static void Print(string[] Words)
{
    Console.WriteLine();
    foreach (var sub in Words)
    {
        Console.WriteLine($": {sub}");
    }
}

/// <summary>
/// Метод, позволяющий переставить элементы строкового массива в обратном порядке
/// </summary>
/// <param name="Phrase">Исходная фраза для разделения на слова и последующей сортировки</param>
static string ReversWords(string Phrase)
{
    string[] arrayWords = SplitString(Phrase);
    string resultString = "";    
    for (int i = arrayWords.Length; i > 0 ; i--)
    {
        resultString +=  arrayWords[i - 1] + " ";        
    }
    return resultString;
}


byte exit = 0;
while (exit != 1)
{
    // Вывод меню и выбор задачи

    Console.Clear();
    Console.WriteLine($"{"\tМЕНЮ:\n1 - Разделить фразу на слова\n2 - Переставить слова в обратном порядке\n0 - Выход\n\n====="}");
    Console.Write("\nВыберите пункт меню: ");

    byte inNum = byte.Parse(Console.ReadLine());

    if (inNum >= 0 && inNum <= 2) ;
    {
        switch (inNum)
        {
            case 0: exit = 1; break;    // Выход из программы
            
            case 1:                     // Делим фразу на слова

                Heading("Делим фразу на слова");
                string str = Console.ReadLine();                
                string[] arrayStr = SplitString(str);                    
                Print(arrayStr);
                
                break;

            case 2:                     // Переставляем слова в обратном порядке

                Heading("Переставляем слова в обратном порядке");
                string resultStr = ReversWords(Console.ReadLine());
                Console.Write($"\nРезультат:     {resultStr}");
                break;
        }
    }

    Console.ReadKey();
}

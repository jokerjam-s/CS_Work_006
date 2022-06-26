/**
* Задача 41.
* 
* Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*
* 0, 7, 8, -2, -2 -> 2
* -1, -7, 567, 89, 223-> 3
*
* P.S.: данные от пользователя считаем всегда корректными, 
* в строке только допустимые знаки (- перед отрицательными, цифры от 0 до 9, запятые в качестве разделителя)
* числа не содержат незначащих нулей (09 - неверное представленеи числа 9)
*/


// запрос строкового значения у пользователя
// параметры:
//      message - выводимое сообщение пользователю
// возврат:
//      число, введенное пользователем в консоли
string InputStrOfNumber(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

// рекурсивный поиск положительных чмсел в строке пользователя
// параметры:
//      strOfNumbers - заданная пользователем строка
// возврат:
//      количество положительных чисел в строке
int CountEvenNumOfStr(string strOfNumbers)
{
    int countEvenNum = 0;

    if (strOfNumbers[0] != '-' && strOfNumbers[0] != '0')
    {
        countEvenNum = 1;
    }

    string newStrOfNumbers = string.Empty;
    int commaPos = FindFirstChar(strOfNumbers, ',');
    if(commaPos >= 0)
    {
        for (int i = commaPos + 1; i < strOfNumbers.Length; i++)
        {
            newStrOfNumbers += strOfNumbers[i];
        }
    }

    if(newStrOfNumbers != string.Empty){
        countEvenNum += CountEvenNumOfStr(newStrOfNumbers);
    }

    return countEvenNum;
}

// поиск позиции первого вхождения символа в строку слева
// параметры:
//      searchSource - строка для поиска
//      findValue    - искомое значение
// возврат:
//      номер первой позиции искомого символа в строке
//      если символ не найден -1
int FindFirstChar(string searchSource, char findValue)
{
    int result = -1;

    for (int i = 0; i < searchSource.Length; i++)
    {
        if (searchSource[i] == findValue)
        {
            result = i;
            break;
        }
    }

    return result;
}


// main body
Console.Clear();
string strOfNumbers = InputStrOfNumber("Input string of numbers: ");
Console.WriteLine($"Count even numbers is {CountEvenNumOfStr(strOfNumbers)}");

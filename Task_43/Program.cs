/**
*   Задача 43.
*
* Напишите программу, которая найдёт точку пересечения двух прямых, 
* заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
* значения b1, k1, b2 и k2 задаются пользователем.
* b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)* - ошибка ы условии, верно (-0,5; -0,5)
*
* решая систему уравнений для y, найдем x = (b2 - b1)/(k1 - k2)
*
*/

// запрос численного значения у пользователя
// параметры:
//      message - выводимое сообщение пользователю
// возврат:
//      число, введенное пользователем в консоли
int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// расчет значения X
double CalcX(int b1, int b2, int k1, int k2)
{
    return ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
}

// расчет значения Y
double CalcY(int b, int k, double x)
{
    return (double)k * x + (double)b;
}

// main body
// коэффициенты
int b1 = InputNumber("Input b1: "); 
int b2 = InputNumber("Input b2: "); 
int k1 = InputNumber("Input k1: "); 
int k2 = InputNumber("Input k2: ");

double x = CalcX(b1, b2, k1, k2);
double y = CalcY(b1, k1, x);

Console.WriteLine($"Crosspoint (x, y) = ({x}, {y})");


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/* АЛГОРИТМ
1. Метод получения чисел из консоли
2. Метод нахождения х
3. Метод нахождения у
4. Метод определения точки пересечения
*/

/* y = k1 * x + b1

   y = k2 * x + b2
*/

double GetNumber(string message)
{
    double result = 0;

    Console.Write(message);

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод: ");
        }
    }

    return result;
}

double GetValueX(double b1, double k1, double b2, double k2)
{
    double result = new double();

    result = -(b1 - b2) / (k1 - k2);

    return result;
}

double GetValueY(double b1, double k1, double x)
{
    double result = new double();

    result = k1 * x + b1;

    return result;
}

void GetPointOfEquations(double k1, double k2, double x, double y)
{
    if(k1 == k2)
    {
        Console.WriteLine("Прямые параллельны или совпадают.");
    }
    else
    {
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}; {y}) ");
    }
}

double b1 = GetNumber("Введите значение для b1: ");
double k1 = GetNumber("Введите значение для k1: ");
double b2 = GetNumber("Введите значение для b1: ");
double k2 = GetNumber("Введите значение для k2: ");

double x = GetValueX(b1, k1, b2, k2);
double y = GetValueY(b1, k1, x);

Console.WriteLine($"y = {k1}x + {b1} ");
Console.WriteLine($"y = {k2}x + {b2} ");
GetPointOfEquations(k1, k2, x, y);
/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

/*
АЛГОРИТМ
1. Метод получения чисел из консоли
2. Метод инициализации массива
3. Метод печати массива
4. Метод подсчёта положительных чисел в массиве
*/

int GetNumber(string message)
{
    int result = 0;

    Console.Write(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число повторите ввод: ");
        }
    }

    return result;
}

int[] InitArray(int dimensin, int leftBound, int rigthBound)
{
    int[] result = new int[dimensin];

    Random rnd = new Random();

    for (int i = 0; i < dimensin; i++)
    {
        result[i] = rnd.Next(leftBound, rigthBound);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int GetPositiveNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }

    return count;
}

int dimensin = GetNumber("Введите размерность массива: ");
int leftBound = GetNumber("Введите левую границу массива: ");
int rigthBound = GetNumber("Введите правую границу массива: ");

int[] arr = InitArray(dimensin, leftBound, rigthBound);

PrintArray(arr);

int count = GetPositiveNumbers(arr);
Console.WriteLine($"Количество положительных чисел в массиве: {count}");
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

 // Ввод
int ImputConsole()
{
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число: ");
    return size;
}

// Создаем двумерный массив, заполняем случайными значениями
int[,] SpiralFilling(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int num = 1;
    // количество колец
    int ring = rows % 2 == 0 && columns % 2 == 0 ? rows / 2
                : rows > columns ? columns / 2 + 1 : rows / 2 + 1;

    // заполнение колец внутрь
    for (int i = 0; i < ring; i++)
    {
        // заполнение вправо
        for (int toRight = i; toRight < columns - i; toRight++)
        {
            array[i, toRight] = num;
            num++;
        }

        // заполнение вниз
        for (int toDown = 1 + i; toDown < rows - 1 - i; toDown++)
        {
            array[toDown, columns - 1 - i] = num;
            num++;
        }

        // выход из цикла заполнения
        if (ring % 2 != 0 && i == ring - 1 && rows > columns)
        {
            array[rows - 1 - i, columns - 1 - i] = num;
            break;
        }
        // выход из цикла заполнения
        if (columns % 2 != 0 && ring % 2 == 0 && i == ring - 1 && rows > columns)
        {
            array[rows - 1 - i, columns - 1 - i] = num;
            break;
        }

        // заполнение влево
        for (int toLeft = columns - 1 - i; toLeft >= i; toLeft--)
        {
            if (rows - i == ring && rows % 2 != 0)
                break;
            array[rows - 1 - i, toLeft] = num;
            num++;
        }
        // заполнение вверх
        for (int toUp = rows - 2 - i; toUp > i; toUp--)
        {
            array[toUp, i] = num;
            num++;
        }
    }
    return array;
}

// Вызов создания матрицы
int[,] NewMatrix()
{
    Console.WriteLine("Введите параметры размер матрицы Rows и Columns (натуральные > 0)");
    Console.Write("Введите Rows: ");
    int rows = ImputConsole();
    Console.Write("Введите Columns: ");
    int columns = ImputConsole();

    return SpiralFilling(rows, columns);
}

// Печать массива
void PrintMatrix(int[,] array)
{
    // расчет количества знаков
    int maxNumber = array.Length;
    int f = array.Length.ToString().Length;
    // сделаем не меньше 2х
    f = f < 2 ? 2 : f;
    
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString($"D{f}"));
            if (j < array.GetLength(1) - 1)
                Console.Write("\t");
            else
                Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Программа заполнит матрицу любого размера по часовой стрелке, значениями от 1 до m x n.");
Console.WriteLine("Матрица не обязательно должна быть квадратной");
int[,] matrix = NewMatrix();
Console.WriteLine("Сгенерированая матрица: ");
PrintMatrix(matrix);
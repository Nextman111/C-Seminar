// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


// Ввод
int ImputConsole(){
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число");
    return size;
}

// Создаем двумерный массив, заполняем случайными значениями
int[,] ТwoDimensionalArrayRandom(int m, int n){
    var array = new int[m,n];
    var rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i,j] = rand.Next(0,100);
        }
    }
    return array;
}

// Печать массива
void PrintTwoDimensionalArray(int[,] array){
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]);
            if(j < array.GetLength(1)-1)
                Console.Write("\t");
            else
                Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// Поиск элемента в двуамерном массиве
int FindeInTwoDimensionArray(int[,] array, int m, int n){
    if (array.GetLength(0) > m &&
        array.GetLength(1) > n &&
        m > 0 &&
        n > 0)
        return array[m,n];
    else
        throw new Exception("Такого элемента не существует");
}
Console.Clear();
Console.WriteLine($"Введите размер параметры массива m и n (натуральные > 0)");

Console.Write($"Введите m: ");
int m = ImputConsole();

Console.Write($"Введите n: ");
int n = ImputConsole();

int[,] matrix = ТwoDimensionalArrayRandom(m,n);
PrintTwoDimensionalArray(matrix);

Console.WriteLine($"Введите позицию элемента, чтобы получить значение ( m = [0,{m-1}] и n = [0,{n-1}])");

//значения поиска
Console.Write($"Введите m: ");
int mf = ImputConsole();
//
Console.Write($"Введите n: ");
int nf = ImputConsole();

try
{
    Console.WriteLine(FindeInTwoDimensionArray(matrix,mf,nf));
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}
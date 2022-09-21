// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5   7    -2    -0,2
// 1    -3,3   8    -9,9
// 8     7,8  -7,1   9

// Ввод
int ImputConsole(){
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число");
    return size;
}

// Создаем двумерный массив, заполняем случайными значениями
double[,] ТwoDimensionalArrayRandom(int m, int n){
    var array = new double[m,n];
    var rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i,j] = (double)rand.Next(-99,100)/10;
        }
    }
    return array;
}

// Печать массива
void PrintTwoDimensionalArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]);
            if(j < array.GetLength(1)-1)
                Console.Write("\t");
            else
                Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine($"Введите размер параметры массива m и n (натуральные > 0)");

Console.Write($"Введите m: ");
int m = ImputConsole();

Console.Write($"Введите n: ");
int n = ImputConsole();
PrintTwoDimensionalArray(ТwoDimensionalArrayRandom(m,n));

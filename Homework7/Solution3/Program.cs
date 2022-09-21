// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            array[i,j] = rand.Next(0,10);
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

// Поиск среднего арифметического
double[] ColumnsOrRowsAverage(int[,] array, bool columns){
    double[] average = new double[ columns ? array.GetLength(1) : array.GetLength(0) ];
    int sum = 0;
    if (columns){
        for( int j = 0; j < array.GetLength(1); j++){
            for( int i = 0; i < array.GetLength(0); i++){
                sum += array[i,j];
            }
            average[j] = (double)sum/array.GetLength(0);
            sum = 0;
        }
    }   
    else{
        for( int i = 0; i < array.GetLength(0); i++){
            for( int j = 0; j < array.GetLength(1); j++){
                sum += array[i,j];
            }
            average[i] = (double)sum/array.GetLength(1);
            sum = 0;
        }
    }   
    return average;
}

void PrintColumnsOrRowsAverage(double[] average, bool columns){
    foreach(var el in average){
        if (columns)
            Console.Write($"{el}\t");
        else
            Console.WriteLine(el);
        
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine($"Введите параметры размер массива m и n (натуральные > 0)");

Console.Write($"Введите m: ");
int m = ImputConsole();

Console.Write($"Введите n: ");
int n = ImputConsole();

// Инициализация и вывод сгенерированного двумерного массива
int[,] matrix = ТwoDimensionalArrayRandom(m,n);
PrintTwoDimensionalArray(matrix);

// Среднее по столбцам
Console.WriteLine("Средние значения по столбцам: ");
PrintColumnsOrRowsAverage(ColumnsOrRowsAverage(matrix,true),true);

// Среднее по строкам
Console.WriteLine("Средние значения по cтрокам: ");
PrintColumnsOrRowsAverage(ColumnsOrRowsAverage(matrix,false),false);

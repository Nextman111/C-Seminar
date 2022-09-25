// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Ввод
int ImputConsole(){
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число: ");
    return size;
}

// Создаем двумерный массив, заполняем случайными значениями
int[,] ТwoDimensionalArrayRandom(int Rows, int Columns){
    var array = new int[Rows,Columns];
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

void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine($"Строка {i}\t{array[i]}");
    }
    Console.WriteLine();
}

// Сортировка по строкам
int[] SumRowsDimensionalArray(int[,] matrix){
    int[] sumRows = new int[matrix.GetLength(0)];
    for(int Rows = 0; Rows < matrix.GetLength(0); Rows++)
        for(int Columns = 0; Columns < matrix.GetLength(1); Columns++)
            sumRows[Rows] += matrix[Rows,Columns]; 
    return sumRows; 
}

// Строка номер строки с минимальной суммой
int MinSumRow(int[] sumRows){
    int minRow = 0;
    for(int i = 1; i < sumRows.Length; i++)
        if(sumRows[minRow] > sumRows[i]) 
            minRow = i;    
    return minRow;
}

Console.Clear();
Console.WriteLine("Введите параметры размер массива Rows и Columns (натуральные > 0)");

Console.Write("Введите Rows: ");
int Rows = ImputConsole();

Console.Write("Введите Columns: ");
int Columns = ImputConsole();

int[,] matrix = ТwoDimensionalArrayRandom(Rows,Columns);

Console.Write("Сгенерированый массив: ");
PrintTwoDimensionalArray(matrix);

// Полученые значения
Console.WriteLine("Суммы элементов строк: ");
int[] sumRow = SumRowsDimensionalArray(matrix);
PrintArray(sumRow);

// Номер строки с наименьшей суммой
Console.WriteLine("Номер строки с наименьшей суммой: ");
Console.WriteLine(MinSumRow(sumRow));
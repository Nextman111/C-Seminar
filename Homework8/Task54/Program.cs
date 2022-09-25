// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

//Сортировка по строкам
int[,] SortRowsDimensionalArray(int[,] matrix, bool increse = true){
    int tmp;
    for(int Rows = 0; Rows < matrix.GetLength(0); Rows++)
        for(int Columns = 0; Columns < matrix.GetLength(1); Columns++)
            for(int i = Columns + 1; i < matrix.GetLength(1); i++)
                if( increse 
                    ? matrix[Rows,i] < matrix[Rows,Columns]
                    : matrix[Rows,i] > matrix[Rows,Columns])
                {
                    tmp = matrix[Rows,i];
                    matrix[Rows,i] = matrix[Rows,Columns];
                    matrix[Rows,Columns] = tmp;
                }    
    return matrix; 
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

// Сортировка строк по убыванию
Console.WriteLine("Сортировка строк по убыванию: ");
PrintTwoDimensionalArray(SortRowsDimensionalArray(matrix,false));
// Сортировка строк по возрастанию
Console.WriteLine("Сортировка строк по возрастанию: ");
PrintTwoDimensionalArray(SortRowsDimensionalArray(matrix));


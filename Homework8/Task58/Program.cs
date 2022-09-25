// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




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
void PrintMatrix(int[,] array){
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

int[,] NewMatrix(){
    Console.WriteLine("Введите параметры размер матрицы Rows и Columns (натуральные > 0)");
    Console.Write("Введите Rows: ");
    int Rows = ImputConsole();
    Console.Write("Введите Columns: ");
    int Columns = ImputConsole();

    return ТwoDimensionalArrayRandom(Rows,Columns);
}

// Проверка на согласованность матриц
bool IsConsistentMatrix(int[,] matrix1, int[,] matrix2) => matrix1.GetLength(1) == matrix2.GetLength(0);

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2){
    int[,] matrixMult = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    
    for(int i = 0; i < matrix1.GetLength(0); i++)
        for(int j = 0; j < matrix2.GetLength(1); j++)
            for(int k = 0; k < matrix1.GetLength(1); k++)
            matrixMult[i,j] += matrix1[i,k] * matrix2[k,j];
    return matrixMult;
}

Console.Clear();

int[,] matrix1 = NewMatrix();
Console.Write("Сгенерированая матрица 1: ");
PrintMatrix(matrix1);

int[,] matrix2 = NewMatrix();
Console.Write("Сгенерированая матрица 2: ");
PrintMatrix(matrix2);

//Проверка на согласованность матриц
if (IsConsistentMatrix(matrix1,matrix2)){
    Console.WriteLine("Матрицы согласованы, можно приступать к умножению.");
    PrintMatrix(MatrixMultiplication(matrix1,matrix2));
}
else{
    Console.WriteLine("Матрицы не согласованы, умножение невозможно.");
    Console.WriteLine("Матрицы считаются согласованными когда число столбцов в первом сомножителе равно числу строк во втором.");
}
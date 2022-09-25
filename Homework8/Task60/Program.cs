// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Ввод
int ImputConsole(){
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число: ");
    return size;
}

// Генератор случайных неповторяющихся чисел
int[] RandomNoRepeat(int size, int start, int end){
    var rand = new Random();
    int[] noRepeat = new int[size];
    int num = rand.Next(start,end);
    for(int i = 0; i < noRepeat.Length; i++){
        while(noRepeat.Contains(num)) 
            num = rand.Next(start, end);
        noRepeat[i] = num; 
    }    
    return noRepeat;
}

// Создаем двумерный массив, заполняем случайными значениями
int[,,] ThriDimensionalArrayRandom(int a, int b, int c){
    // Всего двузначных чисел в интервале [10,99] = 89
    int size = a*b*c;
    if (size > 89)
        throw new Exception("Двузначных неповторяющихся чисел меньше чем элементов массива");
        
    int[] noRepeat = RandomNoRepeat(size:size, start: 10, end: 100);
    var thriDimensionalArray = new int[a,b,c];
    
    for(int i = 0; i < thriDimensionalArray.GetLength(0); i++)
        for(int j = 0; j < thriDimensionalArray.GetLength(1); j++)
            for(int k = 0; k < thriDimensionalArray.GetLength(2); k++){
                size--;
                thriDimensionalArray[i,j,k] = noRepeat[size];
                
            }
    return thriDimensionalArray;
}

// Печать трехмерного массива
void PrintThriDimensionalArray(int[,,] thriDimensionalArray){
    for(int i = 0; i < thriDimensionalArray.GetLength(0); i++){
        for(int j = 0; j < thriDimensionalArray.GetLength(1); j++){
            for(int k = 0; k < thriDimensionalArray.GetLength(2); k++){
                Console.Write($"{thriDimensionalArray[i,j,k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность трехмерного массива (a, b, c) > 0:");
Console.WriteLine("Введите размерность a > 0: ");
int a = ImputConsole();
Console.WriteLine("Введите размерность b > 0: ");
int b = ImputConsole();
Console.WriteLine("Введите размерность c > 0: ");
int c = ImputConsole();

try{   
    var array = ThriDimensionalArrayRandom(a,b,c);
    Console.WriteLine("Трехмерный массив: ");
    PrintThriDimensionalArray(array);   
}
catch (System.Exception ex){
    Console.WriteLine($"{ex.Message}");
}
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//генератор массива
double[] ArrayGenerator(int size){
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.NextDouble()*rand.Next(-1000,1000);
    }
    return array;
}

//печать массива в консоль
void ArrayConsolePrint(double[] array){
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"{i} => {array[i]}");
    }
    Console.WriteLine("-------------------------------------------");
}

//finde Min/Max in array
// Min = minMax[0]
// Max = minMax[1]
int[] FindeMinMaxInArray(double[] array){
    int[] minMax = new int[2];
    minMax[0] = minMax[1] = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[minMax[0]] > array[i]){
            minMax[0] = i;
        }
        if(array[minMax[1]]<array[i]){
            minMax[1] = i;
        } 
    }
    return minMax;
}

Console.WriteLine("Введите размер массива натуральное число.\n"
                +"Программа сгенерирует массив из вещественных чисел.\n"
                +"Найдет минимальное и максимальное значение.\n"+
                "Выведет разницу между минимальным и максимальным значением.");int size;
while (int.TryParse(Console.ReadLine(), out size) == false || size < 1){
    Console.WriteLine("Некорректное значение, введите натуральное число");
}
double[] array = ArrayGenerator(size);
ArrayConsolePrint(array);

if(array.Length < 2){
    Console.WriteLine("Элемент всего один: \n"
                    +"Он же минимум, он же и максимум! А значит и разница равна 0.");
}
else{
    int[] minMax = FindeMinMaxInArray(array);
    Console.WriteLine($"Минимум {minMax[0]} элемент со значением {array[minMax[0]]}\n"+
                    $"Максимум {minMax[1]} элемент со значением {array[minMax[1]]}");

    Console.WriteLine("Разница между максимальным и минимальными значениями равна:\n"
                    +$"{array[minMax[1]]} - {array[minMax[0]]} = {array[minMax[1]] - array[minMax[0]]}\n");
}
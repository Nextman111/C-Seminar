// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//генератор массива
int[] ArrayGenerator(int size){
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(-99,99);
    }
    return array;
}

//печать массива в консоль
void ArrayConsolePrint(int[] array){
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"{i} => {array[i]}");
    }
    Console.WriteLine("-------------------------------------------");
}

//Сумма четных чисел в массиве
int SumEvenInArray(int[] array){
    int sumEven = 0;
    for(int i = 0; i<array.Length;i +=2){
        sumEven +=array[i];
    }    
    return sumEven;
}

//Сумма нечетных чисел в массиве
int SumOddInArray(int[] array){
    int sumEven = 0;
    for(int i = 1; i<array.Length;i +=2){
        sumEven +=array[i];
    }    
    return sumEven;
}


Console.WriteLine("Введите размер массива натуральное число,"
                +" программа сгенерирует массив из случайных чисел от -99 до 100"
                +" и посчитает сумму четных и нечетных элементов");

int size;
while (int.TryParse(Console.ReadLine(), out size) == false || size < 1){
    Console.WriteLine("Некорректное значение, введите натуральное число");
}
 
int[] array = ArrayGenerator(size);
ArrayConsolePrint(array);
Console.WriteLine("В сгенерированном массиве:\n"
                +$"Сумма четных элементов {SumEvenInArray(array)}\n"     
                +$"Сумма нечетных элементов {SumOddInArray(array)}");
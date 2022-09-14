// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//генератор массива
int[] ArrayGenerator(int size){
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(100,1000);
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

//Количество четных чисел в массиве
int CountEvenInArray(int[] array){
    int even = 0;
    foreach(int el in array){
        if (el%2 == 0){
            even++;
        }
    }
    return even;
}

Console.WriteLine("Введите размер массива натуральное число.\n"
                +"Программа сгенерирует массив из положительных трехзначных чисел.\n"
                +"И выведет количество четных и нечетных чисел.");int size;
while (int.TryParse(Console.ReadLine(), out size) == false || size < 1){
    Console.WriteLine("Некорректное значение, введите натуральное число");
}
int[] array = ArrayGenerator(size);
ArrayConsolePrint(array);
Console.WriteLine("Элементов в сгенерированном массиве:\n"
                +$"{CountEvenInArray(array)} четных\n"     
                +$"{array.Length - CountEvenInArray(array)} нечетных");
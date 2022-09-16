// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//печать массива в консоль
void ArrayConsolePrint(int[] array){
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"{i+1} => {array[i]}");
    }
    Console.WriteLine("-------------------------------------------");
}

//Поиск положительных >0
int FindePositiveInArray(int[] array){
    int count = 0;
    foreach (var el in array){
        if (el >0){
            count++;
        }        
    }
    return count;
}

Console.WriteLine($"Введите размер массива M > 0");
int size = 0;
while (int.TryParse(Console.ReadLine(), out size) == false || size < 1){
    Console.WriteLine("Некорректное значение, введите натуральное число");
}
Console.WriteLine($"Введите числа:");
int[] array = new int[size];
int el;
for (int i = 0; i < size; i++){
    Console.WriteLine($"Введите числo {i+1}:");
    while (int.TryParse(Console.ReadLine(), out el) == false){
        Console.WriteLine("Некорректное значение, введите натуральное число");
    }
    array[i] = el;   
}

ArrayConsolePrint(array);
int positive = FindePositiveInArray(array);
Console.WriteLine($"Количество элементов > 0 : {positive}");
Console.WriteLine($"Количество элементов < 0 : {array.Length-positive}");
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//генератор массива
int[] ArrayGenerator(int size){
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(-9,10);
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

//Метод расчета произведения
int[] MultiplicationPairOfArrayElements(int[] array){ 
    int[] multiplication = new int[array.Length/2];
    for(int i = 0, j = array.Length-1; i<j; i++,j--){
        multiplication[i] = array[i] * array[j];
    }
    return multiplication;
}

//Вывод произведения
void PrintMultiplicationPairOfArrayElements(int[] array, int[] multiplication){
    if( multiplication.Length < 1){
        Console.WriteLine("К сожалению в массиве только один элемент и у него нет пары.\n"
                        +$"Тогда посчитаем для него квавдрат {array[0]}^2 = {Math.Pow(array[0],2)}");
    }
    for(int i = 0, j = array.Length-1; i<j; i++,j--){
        Console.WriteLine($"{i+1}. Элементы [{i}] и [{j}]   {array[i]} * {array[j]} = {multiplication[i]}");
    }
}


Console.WriteLine("Введите размер массива натуральное число,"
                +" программа сгенерирует массив из случайных чисел от -9 до 10"
                +" и посчитает произведение пар чисел (Первый с последним и тд.)");

int size;
while (int.TryParse(Console.ReadLine(), out size) == false || size < 1){       
    Console.WriteLine("Некорректное значение, введите натуральное число");
}
 
int[] array = ArrayGenerator(size);
ArrayConsolePrint(array);
PrintMultiplicationPairOfArrayElements(array,MultiplicationPairOfArrayElements(array));
// Задача 29: Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран.
// Элементы массива вводятся пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//метод ввода
double ImputElement(){
    double el = 0;
    while (double.TryParse(Console.ReadLine().Replace('.',','), out el) == false){
        Console.WriteLine("Некорректное значение, введите число, можно дробное");
    }
    return el;
}

//метод вывода
void PrintConsole(double[] array){
    Console.WriteLine("");
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"{i+1} => {array[i]}");
    }    
}

Console.WriteLine("Заполните числами массив из 8ми элементов");

//вызов ввода
double[] array = new double[8];
for (int i = 0; i < array.Length; i++){
    Console.Write($"Введите {i+1} элемент (число) ");
    array[i] = ImputElement();
}

PrintConsole(array);
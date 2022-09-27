// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Ввод
int ImputConsole()
{
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число: ");
    return size;
}

void FactorialRange(int n){
    Console.Write(n);
    if(n != 1){
        Console.Write(" + ");
        FactorialRange(n-1);
    }
}
 

Console.WriteLine("Введите натуральноче число N, программа покажет числа в промежутке от N до 1:");
int n = ImputConsole();


FactorialRange(n);
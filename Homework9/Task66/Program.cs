// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Ввод
int ImputConsole()
{
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число: ");
    return size;
}

int FactorialRangeSumm(int m, int n){
    if(m > n)
        (m, n) = (n, m);
    if(m == n) 
        return m;
    return n+FactorialRangeSumm(m,n-1);
}
 

Console.WriteLine("Введите натуральные числа M и N, программа найдет сумму натуральных элементов в промежутке от M до N:");
Console.WriteLine("Введите M: ");
int m = ImputConsole();
Console.WriteLine("Введите N: ");
int n = ImputConsole();

Console.WriteLine(FactorialRangeSumm(m,n));

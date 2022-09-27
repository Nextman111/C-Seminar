// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Ввод
int ImputConsole()
{
    int size;
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
        Console.Write("Некорректное значение, введите натуральное число: ");
    return size;
}

int FactorialAkkerman(int m, int n){
    if(m == 0)
        return n + 1;
    if(m > 0 && n == 0)
        return FactorialAkkerman(m-1,1);
    if(m > 0 && n > 0)
        return FactorialAkkerman(m-1,FactorialAkkerman(m, n-1));
    return 0;
}
 

Console.WriteLine("Введите натуральные числа M и N, программа найдет сумму натуральных элементов в промежутке от M до N:");
Console.WriteLine("Введите M: ");
int m = ImputConsole();
Console.WriteLine("Введите N: ");
int n = ImputConsole();

Console.WriteLine(FactorialAkkerman(m,n));

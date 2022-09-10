// Задача 25: Напишите МЕТОД, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//степень
double Power(double a, int b){
    if (b == 1){
        return a;
    }
    return a*Power(a,b-1);
}

Console.WriteLine("Введите два числа A и B (натуральное), программа расчитает число А в степени B");

//imput A
Console.Write("A = ");
double imputA = 0;
while (double.TryParse(Console.ReadLine().Replace('.',','), out imputA) == false){
    Console.WriteLine("Некорректное значение, введите число, можно дробное");
}

//imput B
Console.Write("B = ");
int imputB = 0;
while (int.TryParse(Console.ReadLine(), out imputB) == false || imputB < 1){
    Console.WriteLine("Некорректное значение, введите натуральное число");
}

//вывод
Console.WriteLine($"{imputA} в степени {imputB} равно {Power(imputA,imputB)}");
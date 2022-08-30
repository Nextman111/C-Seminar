//Напишите программу,
//которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго

Console.Write("Введите первое число");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите первое число");
int a2 = int.Parse(Console.ReadLine());

if (a2*a2 == a1){
    Console.Write($"{a1} является квадратом {a2}");
}
else{
        Console.Write($"{a1} не является квадратом {a2}");
}
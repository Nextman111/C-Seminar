//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Ввод
Console.WriteLine("Введите 3 числа, программа покажет какое максимальное");
Console.Write("Введите первое число ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int a2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int a3 = int.Parse(Console.ReadLine());

//Выполняем условие
int max = a1;
if (max < a2){ max = a2;}
if (max < a3){ max = a3;}

Console.WriteLine($"Максимальное число {max}");
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Ввод
Console.WriteLine("Введите 2 числа, программа покажет какое больше, а какое меньше ");
Console.Write("Введите первое число ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int a2 = int.Parse(Console.ReadLine());

//Выполняем условие
if (a1>a2){
    Console.WriteLine($"{a1} больше, а {a2} меньше");
}else if (a1<a2){
    Console.WriteLine($"{a1} меньше, а {a2} больше");
}else if (a1==a2){
    Console.WriteLine($"{a1} и {a2} равны");
}
//Напишите программу,
//ввадрат числа

Console.Write("Введите число ");
int i = int.Parse(Console.ReadLine()); //приводим к целому типу введенное число
int result = i*i;
Console.WriteLine($"Квадрат числа {i} равен {result}");